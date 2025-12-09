namespace dotnet_project_online_course.DTOs.User
{
    // bu class jullanıcı güncellerken gönderilecek veri
    // Tüm alanlar null sadece değişecek alanlar gönderilir
    public class UpdateUserDto
    {
        public string? Username { get; set; }
        public string? Email { get; set; }

        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}