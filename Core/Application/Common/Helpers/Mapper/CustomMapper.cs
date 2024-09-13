using Application.Handlers.WorkOrderDowntimesManagement.Responses;
using Domain.Entities.SCHEMA1;

namespace Application.Common.Helpers.Mapper
{
    public static class CustomMapper
    {
        public static List<WorkOrderModel> ConvertToWorkOrderModel(this List<WorkOrder> workOrders, List<Downtime> downtimes)
        {
            var workOrderModels = new List<WorkOrderModel>();

            foreach (var workOrder in workOrders)
            {
                var workOrderModel = new WorkOrderModel
                {
                    Id = workOrder.Id,
                    workOrderNo = workOrder.OrderNo,
                    MachineId = workOrder.MachineId,
                    StartTime = workOrder.StartTime ?? workOrder.StartTime ?? DateTime.Now,
                    EndTime = workOrder.EndTime ?? DateTime.Now,
                    DowntimeDurations = new Dictionary<int, DowntimeDetail>(),
                    TotalDowntimeDuration = 0 // Başlangıç değeri sıfır
                };

                workOrderModels.Add(workOrderModel);
            }

            return workOrderModels;
        }
    }
}
