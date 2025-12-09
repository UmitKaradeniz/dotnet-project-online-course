namespace dotnet_project_online_course.DTOs.User
{
    // bu class yeni kullanıcı oluştururken gönderilecek veri için
    public class CreateUserDto
    {
        public required string Username { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }
        public string Role { get; set; } = "Student";
    }
}