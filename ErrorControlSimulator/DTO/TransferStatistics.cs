namespace ErrorControlSimulator.DTO
{
    public class TransferStatistics
    {
        public long FileSize { get; set; }
        public int TotalFrames { get; set; }
        public int? SuccessFrames { get; set; }
        public int? ErrorFrames { get; set; }
        public decimal? LossPercentage { get; set; }
        public double TotalTime { get; set; }
    }
}
