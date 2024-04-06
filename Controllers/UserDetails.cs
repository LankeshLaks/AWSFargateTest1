using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AWSFTest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetails : ControllerBase
    {
        // GET: api/<UserDetails>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "Laks1", "Laks2" });
        }
        
    }
}
