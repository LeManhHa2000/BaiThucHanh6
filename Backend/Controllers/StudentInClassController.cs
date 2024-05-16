using Backend.Models;
using Backend.Service.StudentInClasss;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentInClassController : ControllerBase
    {
        public readonly IStudentInClassService _studentInClassService;
        public StudentInClassController(IStudentInClassService studentInClassService)
        {
            _studentInClassService = studentInClassService;
        }

        // GET: api/<StudentInClassController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentInClassService.GetStudentInClass());
        }

        // GET api/<StudentInClassController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_studentInClassService.GetStudentInClassById(id));
        }

        // POST api/<StudentInClassController>
        [HttpPost]
        public IActionResult Post(StudentInClass student)
        {
            return Ok(_studentInClassService.AddStudentInClass(student));
        }

        // PUT api/<StudentInClassController>/5
        [HttpPut()]
        public IActionResult Put(StudentInClass student)
        {
            return Ok(_studentInClassService.UpdateStudentInClass(student));
        }

        // DELETE api/<StudentInClassController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_studentInClassService.Delete(id));
        }
    }
}
