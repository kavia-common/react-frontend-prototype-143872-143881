using Microsoft.AspNetCore.Mvc;

namespace dotnet_frontend.Controllers
{
    // PUBLIC_INTERFACE
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        /// <summary>
        /// Health check endpoint.
        /// Returns 200 OK with a simple JSON payload indicating the app is healthy.
        /// </summary>
        /// <returns>JSON { status: "ok", service: "dotnet_frontend" }</returns>
        [HttpGet]
        [Route("")]
        [Route("/health")]
        public IActionResult Get()
        {
            return Ok(new { status = "ok", service = "dotnet_frontend" });
        }
    }
}
