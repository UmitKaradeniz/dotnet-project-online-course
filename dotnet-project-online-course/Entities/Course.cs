namespace dotnet_project_online_course.Entities
{
    public class Course : BaseEntity
    {        public string? Title { get; set; }
        public  string? Description { get; set; }

        public decimal Price { get; set; }

        public int InstructorId { get; set; }
        public User Instructor { get; set; } = null!;

        // 1 kursun birden fazla dersi olabilir
        public List<Lesson> Lessons { get; set; } = new List<Lesson>();

        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>(); // öğrenci olarak kayıtlı kullanıcılar
    }
}