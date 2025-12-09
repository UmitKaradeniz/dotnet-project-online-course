using dotnet_project_online_course.DTOs.Course;
using dotnet_project_online_course.DTOs.User;

namespace dotnet_project_online_course.DTOs.Enrollment
{
    // Kayıt bilgilerini döndürürken kullanılır
    public class EnrollmentResponseDto
    {
        public int Id { get; set; }

        public UserResponseDto? User { get; set; }

        public CourseResponseDto? Course { get; set; }

        public DateTime EnrolledAt { get; set; }

        public int CompletionPercentage { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}