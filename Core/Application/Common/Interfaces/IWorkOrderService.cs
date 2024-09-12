using Application.Handlers.WorkOrderDowntimesManagement.Responses;

namespace Application.Common.Interfaces
{
    public interface IWorkOrderService
    {
        List<WorkOrderModel> GetWorkOrdersWithDowntimes();
    }
}
