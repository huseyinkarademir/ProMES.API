namespace Application.Handlers.WorkOrderDowntimesManagement.Responses
{
    public class DowntimeModel
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public int ReasonType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Duration { get; set; } // Dakika cinsinden süresi
    }
}
