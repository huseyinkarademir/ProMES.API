using Application.Common.Interfaces;
using Application.Handlers.WorkOrderDowntimesManagement.Requests;
using Application.Handlers.WorkOrderDowntimesManagement.Responses;
using MediatR;

namespace Application.Handlers.WorkOrderDowntimesManagement.Handlers.Queries
{
    public class GetWorkOrdersQuery : IRequestHandler<GetWorkOrdersQueryRequest, GetWorkOrdersQueryResponse>
    {
 
        private readonly IWorkOrderService _workOrderService;
        public GetWorkOrdersQuery(IWorkOrderService workOrderService)
        {
            _workOrderService = workOrderService;
        }

        public async Task<GetWorkOrdersQueryResponse> Handle(GetWorkOrdersQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetWorkOrdersQueryResponse
            {
                WorkOrderList = _workOrderService.GetWorkOrdersWithDowntimes()
            };
        }
    }
}
