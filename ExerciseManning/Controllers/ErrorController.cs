using Microsoft.AspNetCore.Mvc;

namespace ExerciseManning.Controllers
{
   
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        [HttpGet]
        public IActionResult Error()
        {
            return Problem();
        }
    }
}
