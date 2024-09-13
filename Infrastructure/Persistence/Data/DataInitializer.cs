using Domain.Entities.SCHEMA1;

namespace Persistence.Data
{
    public class DataInitializer
    {
        public static List<WorkOrder> GetWorkOrders()
        {
            return new List<WorkOrder>
            {
                new WorkOrder
                {
                    Id = 1,
                    OrderNo = 1001,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 8, 0, 0),
                    EndTime = new DateTime(2024, 9, 10, 12, 0, 0),
                },
                new WorkOrder
                {
                    Id = 2,
                    OrderNo = 1002,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 13, 0, 0),
                    EndTime = new DateTime(2024, 9, 10, 17, 0, 0),
                },
                new WorkOrder
                {
                    Id = 3,
                    OrderNo = 1003,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 17, 0, 0),
                    EndTime = new DateTime(2024, 9, 10, 19, 0, 0),
                },
                new WorkOrder
                {
                    Id = 4,
                    OrderNo = 1004,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 19, 30, 0),
                    EndTime = new DateTime(2024, 9, 10, 21, 0, 0),
                },
                new WorkOrder
                {
                    Id = 5,
                    OrderNo = 1005,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 13, 20, 10, 0),
                    EndTime = null,
                },
                new WorkOrder
                {
                    Id = 6,
                    OrderNo = 1006,
                    MachineId = 1,
                    StartTime = null,
                    EndTime = null,
                }
            };
        }

        public static List<Downtime> GetDowntimes()
        {
            return new List<Downtime>
            {
                new Downtime
                {
                    Id = 1,
                    Reason = "Arıza",
                    ReasonType = 1,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 16, 40, 0),
                    EndTime = new DateTime(2024, 9, 10, 17, 15, 0)
                },
                new Downtime
                {
                    Id = 2,
                    Reason = "Mola",
                    ReasonType = 2,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 17, 30, 0),
                    EndTime = new DateTime(2024, 9, 10, 17, 45, 0)
                },
                new Downtime
                {
                    Id = 3,
                    Reason = "Setup",
                    ReasonType = 3,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 18, 0, 0),
                    EndTime = new DateTime(2024, 9, 10, 18, 15, 0)
                },
                new Downtime
                {
                    Id = 4,
                    Reason = "Bakım",
                    ReasonType = 4,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 18, 50, 0),
                    EndTime = new DateTime(2024, 9, 10, 19, 45, 0)
                },
                new Downtime
                {
                    Id = 5,
                    Reason = "Arıza",
                    ReasonType = 1,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 18, 20, 0),
                    EndTime = new DateTime(2024, 9, 10, 18, 25, 0)
                },
                new Downtime
                {
                    Id = 6,
                    Reason = "Bakım",
                    ReasonType = 4,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 18, 30, 0),
                    EndTime = new DateTime(2024, 9, 10, 18, 38, 0)
                },
                new Downtime
                {
                    Id = 7,
                    Reason = "Bakım",
                    ReasonType = 4,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 10, 18, 40, 0),
                    EndTime = new DateTime(2024, 9, 10, 18, 43, 0)
                },
                new Downtime
                {
                    Id = 8,
                    Reason = "Bakım",
                    ReasonType = 4,
                    MachineId = 1,
                    StartTime = new DateTime(2024, 9, 13, 20, 40, 0),
                    EndTime = null,
                }
            };
        }
    }
}
