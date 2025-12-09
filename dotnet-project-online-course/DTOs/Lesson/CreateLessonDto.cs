namespace dotnet_project_online_course.DTOs.Lesson
{
    // yeni ders oluştururken gönderilecek veri
    public class CreateLessonDto
    {
        public required string Title { get; set; }

        public string? Content { get; set; }

        public string? VideoUrl { get; set; }

        public int OrderIndex { get; set; }

        public int DurationMinutes { get; set; }

        public int CourseId { get; set; }
    }
}