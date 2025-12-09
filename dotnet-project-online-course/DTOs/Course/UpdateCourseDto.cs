namespace dotnet_project_online_course.DTOs.Course
{
    // Kurs güncellerken gönderilecek veri
    public class UpdateCourseDto
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public int? InstructorId { get; set; }
    }
}