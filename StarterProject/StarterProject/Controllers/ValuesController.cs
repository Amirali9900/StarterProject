using Microsoft.AspNetCore.Mvc;

namespace StarterProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
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
