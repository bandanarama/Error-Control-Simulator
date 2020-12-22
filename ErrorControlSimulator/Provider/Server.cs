using ErrorControlSimulator.DTO;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ErrorControlSimulator.Provider
{
    public class Server : SocketBase
    {
        private const int _dataStreamLength = 8 * 1200;
        private byte[] _dataStream = new byte[_dataStreamLength];
        private EndPoint _epSender;
        private string _receivedFilePath;
        private int _totalFrames = 0;
        private sbyte _currentSequenceNumber = 0;

        public event LogEventHandler Log;
        public event StatisticsEventHandler Stats;
        public event ClearEventHandler Clear;

        public Server(string ipAddress, int port, string receivedFilePath)
        {
            _ipAddress = ipAddress;
            _port = port;
            _receivedFilePath = receivedFilePath;
            _totalFrames = 0;
        }

        public void Listen()
        {
            try
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                var server = new IPEndPoint(IPAddress.Parse(_ipAddress), _port);
                _socket.Bind(server);

                _epSender = new IPEndPoint(IPAddress.Any, 0);

                _socket.BeginReceiveFrom(_dataStream, 0, _dataStreamLength, SocketFlags.None, ref _epSender, new AsyncCallback(ReceiveData), _epSender);

                Log($"Server listening on IP Address: {_ipAddress}:{_port}");
            }
            catch (Exception ex)
            {
                Log($"Error setting up Server to Listen. {ex.Message}");
            }
        }

        private void ReceiveData(IAsyncResult asyncResult)
        {
            var packet = new Packet(_dataStream);
            _socket.EndReceiveFrom(asyncResult, ref _epSender);
            Log($"Frame{packet.SequenceNumber} received.");
            ProcessReceivedPacket(packet);

            var acknowledgement = new byte[1];
            acknowledgement[0] = packet.SequenceNumber == 0 ? (byte)1 : (byte)0;
            _socket.SendTo(acknowledgement, 0, acknowledgement.Length, SocketFlags.None, _epSender);

            _socket.BeginReceiveFrom(_dataStream, 0, _dataStreamLength, SocketFlags.None, ref _epSender, new AsyncCallback(ReceiveData), _epSender);
        }

        private void ProcessReceivedPacket(Packet packet)
        {
            if (_totalFrames == 0)
            {
                _start = DateTime.UtcNow;
            }
            _totalFrames++;

            #region SAW

            if (packet.Type < 3)
            {
                if (packet.Type == 0)
                {
                    Log("Start of SAW File Header detected.");
                    Clear();
                    if (!Directory.Exists(Path.GetDirectoryName(_receivedFilePath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(_receivedFilePath));
                    }
                    if (File.Exists(_receivedFilePath))
                    {
                        File.Delete(_receivedFilePath);
                    }
                }
                File.AppendAllText(_receivedFilePath, packet.Message);
                if (packet.Type == 2)
                {
                    _end = DateTime.UtcNow;
                    Log("End of SAW File Header detected.");
                    Stats(new TransferStatistics
                    {
                        TotalFrames = _totalFrames,
                        TotalTime = (_end - _start).TotalSeconds,
                        FileSize = new FileInfo(_receivedFilePath).Length
                    });
                    Log($"Received file stored at: {_receivedFilePath}");
                    _totalFrames = 0;
                }
            }

            #endregion

            if (packet.Type >= 3)
            {
                if (packet.Type == 3)
                {
                    Log("Start of GBN File Header detected.");
                    Clear();
                    if (!Directory.Exists(Path.GetDirectoryName(_receivedFilePath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(_receivedFilePath));
                    }
                    if (File.Exists(_receivedFilePath))
                    {
                        File.Delete(_receivedFilePath);
                    }
                    _currentSequenceNumber = -1;
                }
                if (packet.SequenceNumber == (_currentSequenceNumber + 1) % 8)
                {
                    _currentSequenceNumber = Convert.ToSByte(packet.SequenceNumber);
                    File.AppendAllText(_receivedFilePath, packet.Message);
                    if (packet.Type == 5)
                    {
                        _end = DateTime.UtcNow;
                        Log("End of GBN File Header detected.");
                        Log($"Received file stored at: {_receivedFilePath}");
                        Stats(new TransferStatistics
                        {
                            TotalFrames = _totalFrames,
                            TotalTime = (_end - _start).TotalSeconds,
                            FileSize = new FileInfo(_receivedFilePath).Length
                        });
                        _totalFrames = 0;
                    }
                }
            }
        }
    }
}
