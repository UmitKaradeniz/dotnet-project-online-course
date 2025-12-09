namespace dotnet_project_online_course.DTOs.User
{
    // Kullanıcı giriş yaparken gönderilecek veri
    // JWT Auth için 
    public class LoginDto
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}