namespace WebApplication3.Reposistories
{
    public static class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>
        {
            new Student { StudentID = 1, StudentName = "Ram", StudentAddress = "Kathmandu"  },
            new Student { StudentID = 2, StudentName = "Sita", StudentAddress = "Bhaktapur"  },
            new Student { StudentID = 3, StudentName = "Shyam", StudentAddress = "Lalitpur"  }
        };
    }
}
