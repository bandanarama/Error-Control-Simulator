using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorControlSimulator.DTO
{
    public class Packet
    {
        #region Public Properties

        public byte SequenceNumber { get; set; }
        public short MessageLength { get; set; }
        public byte Type { get; set; }
        public string Message { get; set; }

        #endregion

        public Packet(byte sequenceNumber, byte type, string message)
        {
            SequenceNumber = sequenceNumber;
            Type = type;
            Message = message;
        }

        public Packet(byte[] dataStream)
        {
            SequenceNumber = dataStream[0];
            MessageLength = BitConverter.ToInt16(dataStream, 1);
            Type = dataStream[3];
            Message = Encoding.ASCII.GetString(dataStream, 4, MessageLength);
        }

        public byte[] GetDataStream()
        {
            var dataStream = new List<byte>();
            dataStream.Add(SequenceNumber);
            dataStream.AddRange(BitConverter.GetBytes((short)Message.Length));
            dataStream.Add(Type);
            dataStream.AddRange(Encoding.ASCII.GetBytes(Message));
            return dataStream.ToArray();
        }
    }
}
