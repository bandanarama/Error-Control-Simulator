using ErrorControlSimulator.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using static ErrorControlSimulator.Enumerations.Enumerations;

namespace ErrorControlSimulator.Provider
{
    public class Client : SocketBase
    {
        private string[] _textParts;
        private int _packetLoss;
        private Random _random;
        private int _randomNumber;
        private int _totalFrames = 0;
        private int _errorFrames = 0;
        private int _successfulFrames = 0;
        private int _windowSize = 7;

        public event LogEventHandler Log;
        public event StatisticsEventHandler Stats;
        public event ProgressEventHandler Progress;
        public Protocol CurrentProtocol { get; set; }


        public Client(string ipAddress, int port)
        {
            _ipAddress = ipAddress;
            _port = port;
        }

        public void Connect()
        {
            try
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                var epServer = new IPEndPoint(IPAddress.Parse(_ipAddress), _port);
                _socket.Connect(epServer);
                Log($"Client connected to IP Address: {_ipAddress}:{_port}");
            }
            catch (Exception ex)
            {
                Log($"Error setting up Client to Connect. {ex.Message}");
            }
        }

        #region SAW

        private int _currentSawFrameNumber = 0;

        private void DoSAWSend()
        {
            while (_currentSawFrameNumber < _textParts.Length)
            {
                var type = (byte)1;
                if (_currentSawFrameNumber == 0)
                {
                    type = 0;
                }
                if (_currentSawFrameNumber == _textParts.Length - 1)
                {
                    type = 2;
                }
                var seqNumber = _currentSawFrameNumber % 2 == 0 ? (byte)0 : (byte)1;
                var packet = new Packet(seqNumber, type, _textParts[_currentSawFrameNumber]);
                var data = packet.GetDataStream();

                _randomNumber = _random.Next(0, 99);
                _totalFrames++;
                Log($"Random Packet Loss simulator value: {_randomNumber}");
                if (_randomNumber < _packetLoss)
                {
                    Log($"Frame{packet.SequenceNumber} sent.");
                    Thread.Sleep(3000);
                    Log($"Timeout receiving ACK. Retrying same frame.");
                    _errorFrames++;
                }
                else
                {
                    _socket.Send(data, 0, data.Length, SocketFlags.None, out SocketError socketError);
                    Log($"Frame{packet.SequenceNumber} sent.");
                    if (socketError != SocketError.Success)
                    {
                        Log($"Actual socket error sending frame. Will be retried");
                        Thread.Sleep(3000);
                        _errorFrames++;
                    }
                    else
                    {
                        Log($"ACK{(packet.SequenceNumber + 1) % 2} received.");
                        _successfulFrames++;
                        _currentSawFrameNumber++;
                    }
                }
                Progress(_currentSawFrameNumber, _textParts.Length);
            }
            _end = DateTime.Now;
            Stats(new TransferStatistics
            {
                TotalFrames = _totalFrames,
                SuccessFrames = _successfulFrames,
                ErrorFrames = _errorFrames,
                LossPercentage = decimal.Divide(_errorFrames, _totalFrames),
                TotalTime = (_end - _start).TotalSeconds,
                FileSize = _textParts.Sum(t => t.Length)
            });
        }

        public void InitiateSAWSend(string[] textParts, int packetLoss)
        {
            _start = DateTime.Now;
            _textParts = textParts;
            _currentSawFrameNumber = 0;
            _packetLoss = packetLoss;
            _random = new Random((int)DateTime.UtcNow.Ticks);
            _totalFrames = 0;
            _errorFrames = 0;
            _successfulFrames = 0;

            DoSAWSend();
        }

        #endregion

        #region GBN

        private List<GBNFrameInfo> _gbnFrames;
        private int _currentGbnFrameNumber = 0;

        private void DoGBNSend()
        {
            var count = 0;
            while (true)
            {
                _totalFrames++;
                var frameInfo = _gbnFrames.First(f => f.FrameNumber == _currentGbnFrameNumber);
                var data = new Packet(frameInfo.SequenceNumber, frameInfo.Type, _textParts[_currentGbnFrameNumber]).GetDataStream();

                _randomNumber = _random.Next(0, 99);
                Log($"Random Packet Loss simulator value: {_randomNumber}");
                if (_randomNumber < _packetLoss)
                {
                    Log($"Frame{frameInfo.SequenceNumber} sent.");
                    frameInfo.Success = false;
                    _errorFrames++;
                }
                else
                {
                    _socket.Send(data, 0, data.Length, SocketFlags.None, out SocketError socketError);
                    Log($"Frame{frameInfo.SequenceNumber} sent.");
                    if (socketError != SocketError.Success)
                    {
                        Log($"Actual socket error sending frame. Will be retried");
                        frameInfo.Success = false;
                        _errorFrames++;
                    }
                    else
                    {
                        frameInfo.Success = true;
                        _successfulFrames++;
                    }
                }
                count++;
                _currentGbnFrameNumber++;
                Progress(_currentGbnFrameNumber, _textParts.Length);
                if (count >= _windowSize || _currentGbnFrameNumber >= _textParts.Length)
                {
                    var restartFrame = _gbnFrames.FirstOrDefault(f => !f.Success && f.FrameNumber < _currentGbnFrameNumber);
                    if (restartFrame == null)
                    {
                        if (_currentGbnFrameNumber >= _textParts.Length)
                        {
                            break;
                        }
                        Log($"RR{(frameInfo.SequenceNumber + 1) % 8} received.");
                    }
                    else
                    {
                        Log($"REJ{restartFrame.SequenceNumber} received. Restarting transmission from Frame Sequence Number: {restartFrame.SequenceNumber}.");
                        _currentGbnFrameNumber = restartFrame.FrameNumber;
                    }
                    count = 0;
                }
            }
            _end = DateTime.Now;
            Stats(new TransferStatistics
            {
                TotalFrames = _totalFrames,
                SuccessFrames = _successfulFrames,
                ErrorFrames = _errorFrames,
                LossPercentage = decimal.Divide(_errorFrames, _totalFrames),
                TotalTime = (_end - _start).TotalSeconds,
                FileSize = _textParts.Sum(t => t.Length)
            });
        }

        public void InitiateGBNSend(string[] textParts, int packetLoss, int windowSize)
        {
            _start = DateTime.Now;
            _textParts = textParts;
            _packetLoss = packetLoss;
            _random = new Random((int)DateTime.UtcNow.Ticks);
            _totalFrames = 0;
            _errorFrames = 0;
            _successfulFrames = 0;
            _windowSize = windowSize;

            _gbnFrames = new List<GBNFrameInfo>();
            for (var i = 0; i < _textParts.Length; i++)
            {
                _gbnFrames.Add(new GBNFrameInfo
                {
                    FrameNumber = i,
                    SequenceNumber = Convert.ToByte(i % 8),
                    Success = false,
                    TotalFrames = _textParts.Length
                });
            }

            _currentGbnFrameNumber = 0;
            DoGBNSend();
        }

        #endregion
    }
}
