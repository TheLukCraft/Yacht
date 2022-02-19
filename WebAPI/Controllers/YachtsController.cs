using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YachtsController : ControllerBase
    {
        private readonly IYachtsService _yachtsService;
        public YachtsController(IYachtsService yachtsService)
        {
            _yachtsService = yachtsService;
        }
        [SwaggerOperation(Summary ="Retrives all yachts")]
        [HttpGet]
        public IActionResult Get()
        {
            var yachts = _yachtsService.GetAllYachts();
            return Ok(yachts);
        }
        [SwaggerOperation(Summary = "Retrives a specific yacht by unique id")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var yacht = _yachtsService.GetYachtById(id);
            if(yacht == null)
                return NotFound();
            return Ok(yacht);
        }
    }
}
