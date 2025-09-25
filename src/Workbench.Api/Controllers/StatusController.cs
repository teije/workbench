using Microsoft.AspNetCore.Mvc;

namespace Workbench.Api.Controllers;

[Route("api/status")]
[ApiController]
public class StatusController : ControllerBase
{
    [HttpGet("ping")]
    public ActionResult<string> Get()
    {
        return Ok("pong");
    }
}
