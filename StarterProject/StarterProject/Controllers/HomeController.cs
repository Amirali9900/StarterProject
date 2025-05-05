using Microsoft.AspNetCore.Mvc;

namespace StarterProject.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            //get all data from user table



            return Ok(/*return your data in here*/);
        }

        [HttpPost]
        public IActionResult post(/*get you viewmodel*/)
        {
            //create a data in user table



            return Ok(/*return the created data*/);
        }
    }
}
