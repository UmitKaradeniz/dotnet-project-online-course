namespace dotnet_project_online_course.DTOs.User
{
    // Kullanıcı bilgilerini döndürürken kullanılır
    // Hassas bilgiler yok
    public class UserResponseDto
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? Role { get; set; }

        public DateTime CreatedAt { get; set; }

 
    }
}