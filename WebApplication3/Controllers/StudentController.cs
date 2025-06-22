using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class StudentController : ControllerBase
    {
        [HttpGet]
        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { StudentID = 1, StudentName = "Ram", StudentAddress = "Kathmandu"  },
                new Student { StudentID = 2, StudentName = "Sita", StudentAddress = "Bhaktapur"  },
                new Student { StudentID = 3Re, StudentName = "Shyam", StudentAddress = "Lalitpur"  }
            };
            
        }
    }
}
