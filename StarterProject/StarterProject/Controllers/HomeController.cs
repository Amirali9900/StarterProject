using Microsoft.AspNetCore.Mvc;
using StarterProject.Models;

namespace StarterProject.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IDataRepository _dataRepository;

        public HomeController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {

            return Ok(_dataRepository.GetAllData().Select(p => new DataModel
            {
                UserId = p.UserId,
                NameUser = p.NameUser,
                Price = p.Price
            }));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var DataId = _dataRepository.GetById(id);
            if (DataId == null)
                return NotFound();
            return Ok(DataId);
        }

        [HttpPost]
        public IActionResult AddData([FromBody] DataModel dataModel)
        {
            if (dataModel == null || !ModelState.IsValid)
                return BadRequest();

            _dataRepository.AddData(dataModel);
            return CreatedAtAction(nameof(GetById), new { id = dataModel.UserId }, dataModel);
        }
    }
}
