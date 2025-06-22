using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class StudentController : ControllerBase
    {
        [HttpGet]
        public string GetStudents()
        {
            return "This returns a list of students";
            
        }
    }
}
