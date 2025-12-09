namespace dotnet_project_online_course.DTOs
{
    // bu class API cevaplarını standart yapmak için generic response sınıf
    public class ApiResponse<T>
    {
        
        public bool Success { get; set; }

        // "User created successfully" veya "User not found"
        public string? Message { get; set; }

        public T? Data { get; set; }

        // HELPER METODLAR 

        // Başarılı 
        public static ApiResponse<T> SuccessResponse(T data, string message = "Operation successful")
        {
            return new ApiResponse<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        // Hata 
        public static ApiResponse<T> ErrorResponse(string message)
        {
            return new ApiResponse<T>
            {
                Success = false,
                Message = message,
                Data = default  // null
            };
        }
    }
}