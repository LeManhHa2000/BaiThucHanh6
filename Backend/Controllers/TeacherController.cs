using Backend.Models;
using Backend.Service.Teachers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        // GET: api/<TeacherController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_teacherService.GetTeacher());
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TeacherController>
        [HttpPost]
        public IActionResult Post(Teacher teacher)
        {
            return Ok(_teacherService.AddTeacher(teacher));
        }

        // PUT api/<TeacherController>/5
        [HttpPut()]
        public IActionResult Put(Teacher teacher)
        {
            return Ok(_teacherService.UpdateTeacher(teacher));
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_teacherService.Delete(id));
        }
    }
}
