using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LondonHotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RootController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRoot()
        {
            var response = new
            {
                href = "www.google.lk"
            };

            return Ok(response);

        }
    }
}
