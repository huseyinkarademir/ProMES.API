namespace Application.Handlers.WorkOrderDowntimesManagement.Responses
{
    public class WorkOrderModel
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public int MachineId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Dictionary<int, DowntimeDetail> DowntimeDurations { get; set; } // DowntimeType ve Süreleri
        public double TotalDowntimeDuration { get; set; } // Dakika cinsinden toplam duruş süresi

        //public List<DowntimeModel> Downtimes { get; set; }
    }

    public class DowntimeDetail
    {
        public int ReasonType { get; set; } // Duruş tipi (integer)
        public string Reason { get; set; } // Duruş açıklaması (string)
        public double TotalDuration { get; set; } // Toplam duruş süresi (dakika cinsinden)
    }
}
