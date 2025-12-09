namespace dotnet_project_online_course.DTOs.Lesson
{
    // Ders güncellerken gönderilecek veri
    public class UpdateLessonDto
    {
        public string? Title { get; set; }

        public string? Content { get; set; }

        public string? VideoUrl { get; set; }

        public int? OrderIndex { get; set; }

        public int? DurationMinutes { get; set; }

        public int? CourseId { get; set; }
    }
}