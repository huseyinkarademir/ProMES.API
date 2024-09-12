namespace Domain.Entities.SCHEMA1
{
    public class Downtime
    {
        public int Id { get; set; }
        public int ReasonType { get; set; }
        public string Reason { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int MachineId { get; set; }
        public Machine Machine { get; set; }
    }
}
