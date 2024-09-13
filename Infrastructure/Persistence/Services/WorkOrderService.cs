using Application.Common.Helpers.Mapper;
using Application.Common.Interfaces;
using Application.Handlers.WorkOrderDowntimesManagement.Responses;
using Domain.Entities.SCHEMA1;
using Persistence.Data;

namespace Persistence.Services
{
    public class WorkOrderService : IWorkOrderService
    {
        private readonly List<WorkOrder> _workOrders;
        private readonly List<Downtime> _downtimes;

        public WorkOrderService()
        {
            _workOrders = DataInitializer.GetWorkOrders().Where(o => o.StartTime.HasValue && o.StartTime != DateTime.MinValue).ToList();
            _downtimes = DataInitializer.GetDowntimes();
        }

        public List<WorkOrderModel> GetWorkOrdersWithDowntimes()
        {
            // İş emirlerini modellerine dönüştürmek için CustomMapper'ı kullanıyoruz
            var workOrderModels = _workOrders.ConvertToWorkOrderModel(_downtimes);

            foreach (var workOrderModel in workOrderModels)
            {
                var workOrder = _workOrders.FirstOrDefault(o => o.Id == workOrderModel.Id);

                // İlgili iş emrine ait duruşları filtrele
                var relatedDowntimes = _downtimes
                    .Where(d => d.MachineId == workOrder.MachineId &&
                    workOrder.StartTime < (d.EndTime ?? DateTime.MaxValue) &&
                    d.StartTime < (workOrder.EndTime ?? DateTime.MaxValue))
                    .ToList();

                // ReasonType'a göre duruş sürelerini hesapla
                foreach (var downtime in relatedDowntimes)
                {
                    var downtimeDuration = CalculateDowntimeDuration(workOrder, downtime);

                    // Eğer ReasonType daha önce eklenmemişse yeni bir kayıt ekle
                    if (!workOrderModel.DowntimeDurations.ContainsKey(downtime.ReasonType))
                    {
                        workOrderModel.DowntimeDurations[downtime.ReasonType] = new DowntimeDetail
                        {
                            ReasonType = downtime.ReasonType,
                            Reason = downtime.Reason, // Duruş açıklaması
                            TotalDuration = (int)(downtimeDuration.TotalMinutes)
                        };
                    }
                    else
                    {
                        // Var olan kaydın toplam süresini güncelle
                        workOrderModel.DowntimeDurations[downtime.ReasonType].TotalDuration += (int)(downtimeDuration.TotalMinutes);
                    }

                    // İş emrinin toplam duruş süresini güncelle
                    workOrderModel.TotalDowntimeDuration += (int)(downtimeDuration.TotalMinutes);
                }
            }

            return workOrderModels;
        }

        // Duruş süresini hesaplayan metod
        private TimeSpan CalculateDowntimeDuration(WorkOrder workOrder, Downtime downtime)
        {
            var start = downtime.StartTime > workOrder.StartTime ? downtime.StartTime : workOrder.StartTime;
            
            DateTime? downtimeEndTime = downtime.EndTime == null
                                        ? workOrder.EndTime ?? DateTime.Now
                                        : workOrder.EndTime == null ? downtime.EndTime : (downtime.EndTime < workOrder.EndTime ? downtime.EndTime : workOrder.EndTime);

            return downtimeEndTime.Value - start.Value;
        }
    }
}
