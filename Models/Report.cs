namespace RunningReviewApp.Models
{
    public class Report
    {
        public int Id { get; set; }
        public float TotalDistance { get; set; }
        public float AveragePace { get; set; }
        public TimeSpan TotalTime{ get; set; }
    }
}
