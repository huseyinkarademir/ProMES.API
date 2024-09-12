namespace Domain.Entities.SCHEMA1
{
    public class Line
    {
        public int LineNumber { get; set; }
        public string LineName { get; set; }
        public List<Machine> Machines { get; set; }
    }
}
