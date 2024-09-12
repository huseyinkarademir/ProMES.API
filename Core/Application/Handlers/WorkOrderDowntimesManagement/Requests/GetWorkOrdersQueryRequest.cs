using Application.Handlers.WorkOrderDowntimesManagement.Responses;
using MediatR;

namespace Application.Handlers.WorkOrderDowntimesManagement.Requests
{
    public class GetWorkOrdersQueryRequest : IRequest<GetWorkOrdersQueryResponse>
    {
    }
}
