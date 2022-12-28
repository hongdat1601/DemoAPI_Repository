using DemoAPI.Models;
using DemoAPI.Repositories.StudentRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _studentRepo;
        public StudentController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _studentRepo.GetAll();

            if (students != null)
                return Ok(students);

            return BadRequest("Student is Empty!");
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            return Ok("Success");
        }
    }
}
