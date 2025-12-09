namespace dotnet_project_online_course.DTOs.Enrollment
{
    // Öğrenci kursa kaydolurken gönderilecek veri
    public class CreateEnrollmentDto
    {
        public int UserId { get; set; }

        public int CourseId { get; set; }

     
    }
}