namespace dotnet_project_online_course.DTOs.Lesson
{
    // Ders bilgilerini döndürürken kullanılır
    public class LessonResponseDto
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public string? VideoUrl { get; set; }

        public int OrderIndex { get; set; }

        public int DurationMinutes { get; set; }

        public int CourseId { get; set; }

        public string? CourseName { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}