using Application.Handlers.WorkOrderDowntimesManagement.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ProMES.API.Controllers
{
    public class WorkOrderController : BaseController
    {
        [HttpPost("list-workOrders/GetWorkOrders")]
        public async Task<IActionResult> GetWorkOrders([FromBody] GetWorkOrdersQueryRequest request, [FromHeader(Name = "X-Method-Name")] string methodName)
        {
            if (methodName == "GetWorkOrders")
            {
                return Ok(await Mediator.Send(request));
            }
            return BadRequest("Metod ismi yanlış");
        }
    }
}
