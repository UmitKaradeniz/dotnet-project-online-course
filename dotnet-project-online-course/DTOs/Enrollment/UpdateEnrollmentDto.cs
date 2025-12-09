namespace dotnet_project_online_course.DTOs.Enrollment
{
    // Kayıt güncellerken gönderilecek 
    public class UpdateEnrollmentDto
    {
        public int? CompletionPercentage { get; set; }

        public bool? IsCompleted { get; set; }
    }
}