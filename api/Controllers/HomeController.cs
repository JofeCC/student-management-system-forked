namespace API.Controllers {
    using  Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("")]
    public class HomeController: ControllerBase
    {
        [HttpGet]
        public IActionResult ApiIsWroking()
        {
            return Ok(new { Status = "Success", Message = "API is working"});
        }
    }
}