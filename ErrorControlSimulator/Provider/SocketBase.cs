using ErrorControlSimulator.DTO;
using System;
using System.Net.Sockets;

namespace ErrorControlSimulator.Provider
{
    public class SocketBase
    {
        protected string _ipAddress;
        protected int _port;
        protected Socket _socket;
        protected DateTime _start;
        protected DateTime _end;

        public delegate void LogEventHandler(string response);
        public delegate void StatisticsEventHandler(TransferStatistics stats);
        public delegate void ClearEventHandler();
        public delegate void ProgressEventHandler(int current, int total);
    }
}
