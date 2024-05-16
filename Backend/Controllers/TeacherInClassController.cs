using Backend.Models;
using Backend.Service.TeacherInClasss;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherInClassController : ControllerBase
    {
        public readonly ITeacherInClassService _teacherInClassService;
        public TeacherInClassController(ITeacherInClassService teacherInClassService)
        {
            _teacherInClassService = teacherInClassService;
        }

        // GET: api/<TeacherInClassController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_teacherInClassService.GetTeacherInClass());
        }

        // GET api/<TeacherInClassController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_teacherInClassService.GetTeacherInClassById(id));
        }

        // POST api/<TeacherInClassController>
        [HttpPost]
        public IActionResult Post(TeacherInClass teacher)
        {
            return Ok(_teacherInClassService.AddTeacherInClass(teacher));
        }

        // PUT api/<TeacherInClassController>/5
        [HttpPut()]
        public IActionResult Put(TeacherInClass teacher)
        {
            return Ok(_teacherInClassService.UpdateTeacherInClass(teacher));
        }

        // DELETE api/<TeacherInClassController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_teacherInClassService.Delete(id));
        }
    }
}
