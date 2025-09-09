using Microsoft.AspNetCore.Mvc;

namespace MiApiRest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[] { "Juan", "Ana", "Pedro" });
        }
    }
}