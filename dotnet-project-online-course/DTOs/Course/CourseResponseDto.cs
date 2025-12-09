using dotnet_project_online_course.DTOs.User;

namespace dotnet_project_online_course.DTOs.Course
{
    // Kurs bilgilerini döndürürken kullanılır
    public class CourseResponseDto
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public UserResponseDto? Instructor { get; set; } 
       
        public int LessonsCount { get; set; }

        public int EnrolledStudentsCount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}