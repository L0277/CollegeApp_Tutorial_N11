using Microsoft.AspNetCore.Mvc;
using WebApplication3.Reposistories;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return CollegeRepository.Students;
            
        }
    }
}
