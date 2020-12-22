namespace ErrorControlSimulator.DTO
{
    public class GBNFrameInfo
    {
        public int FrameNumber { get; set; }
        public byte SequenceNumber { get; set; }
        public bool Success { get; set; }
        public int TotalFrames { get; set; }
        public byte Type
        {
            get
            {
                if (FrameNumber == 0)
                {
                    return 3;
                }
                if (FrameNumber == TotalFrames - 1)
                {
                    return 5;
                }
                return 4;
            }
        }
    }
}
