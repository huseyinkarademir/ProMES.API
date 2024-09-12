using Application.Handlers.WorkOrderDowntimesManagement.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ProMES.API.Controllers
{
    public class WorkOrderController : BaseController
    {
        [HttpPost("list-workOrders")]
        public async Task<IActionResult> GetWorkOrders(GetWorkOrdersQueryRequest request)
        {
            return Ok(await Mediator.Send(request));
        }
    }
}
