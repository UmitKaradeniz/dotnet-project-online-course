namespace dotnet_project_online_course.Entities
{
    public class User : BaseEntity  
    {
        public  string? Username { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Role { get; set; }

        public List<Course> InstructorCourses { get; set; } = new List<Course>(); // 1-to-Many
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>(); // Many-to-Many
        
    }
}