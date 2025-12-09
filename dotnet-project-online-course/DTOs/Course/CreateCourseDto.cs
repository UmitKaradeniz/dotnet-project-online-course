namespace dotnet_project_online_course.DTOs.Course
{
    // Yeni kurs oluştururken gönderilecek veri
    public class CreateCourseDto
    {
        public required string Title { get; set; }

        public required string Description { get; set; }

        public decimal Price { get; set; }

        public int InstructorId { get; set; }
    }
}