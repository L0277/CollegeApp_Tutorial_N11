

using Microsoft.AspNetCore.Mvc;
using WebApplication3;

namespace CollegeApp.Controllers
{
    [Microsoft.AspNetCore.Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudent()
        {
            return CollegeRepository.Students;
        }
    }
}