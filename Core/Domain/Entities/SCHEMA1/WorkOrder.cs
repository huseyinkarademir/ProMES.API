namespace Domain.Entities.SCHEMA1
{
    public class WorkOrder
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int MachineId { get; set; }
        public Machine Machine { get; set; }
    }
}
