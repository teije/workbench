using Microsoft.AspNetCore.Mvc;
using XAct.Diagnostics.Services.Implementations;

namespace Workbench.Api.Controllers;

[Route("api/status")]
[ApiController]
public class StatusController : ControllerBase
{
    /// <summary>
    /// Health check endpoint
    /// </summary>
    [HttpGet("ping")]
    [ProducesResponseType(typeof(StatusResponse), StatusCodes.Status200OK)]
    public ActionResult<string> Get()
    {
        return Ok("pong");
    }
}
