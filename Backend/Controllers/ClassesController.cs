using Backend.Models;
using Backend.Service.Classs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        public readonly IClassService _IclassService;
        public ClassesController(IClassService iclassService)
        {
            _IclassService = iclassService;
        }

        // GET: api/<ClassesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_IclassService.GetClasses());
        }

        // GET api/<ClassesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_IclassService.GetbyId(id));
        }

        // POST api/<ClassesController>
        [HttpPost]
        public IActionResult Post(Classes classes)
        {
            return Ok(_IclassService.AddClass(classes));
        }

        // PUT api/<ClassesController>/5
        [HttpPut()]
        public IActionResult Put(Classes classes)
        {
            return Ok(_IclassService.UpdateClass(classes));
        }

        // DELETE api/<ClassesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_IclassService.Delete(id));
        }
    }
}
