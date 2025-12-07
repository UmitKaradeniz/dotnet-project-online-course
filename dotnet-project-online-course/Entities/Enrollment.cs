using dotnet_project_online_course.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace dotnet_project_online_course.Entities
{
    public class Enrollment : BaseEntity
    {
        public DateTime EnrolledAt { get; set; } // ne zaman kayıt oldu

        public int CompletionPercentage { get; set; } = 0;  // default %0

        public bool IsCompleted { get; set; } = false;  // default tamamlanmadı
        
        public int UserId { get; set; } // fk
        public User User { get; set; } = null!;
        public int CourseId { get; set; } // fk
        public Course Course { get; set; } = null!;
    }
}
