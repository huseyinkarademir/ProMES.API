namespace Domain.Entities.SCHEMA1
{
    public class Machine
    {
        public int MachineNumber { get; set; }
        public string MachineName { get; set; }
        public int LineId { get; set; }
        public Line Line { get; set; }
        public List<WorkOrder> WorkOrders { get; set; }
        public List<Downtime> Downtimes { get; set; }
    }
}
