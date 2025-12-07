namespace dotnet_project_online_course.Entities
{
    public class Lesson : BaseEntity
    {
        public  string? Title { get; set; }

        public string? Content { get; set; } 

        public string? VideoUrl { get; set; }

      
        public int OrderIndex { get; set; } // Dersin kurs içindeki sırası 1 2 3 ...  

        public int DurationMinutes { get; set; }
        public int CourseId { get; set; } // fk
        public Course Course { get; set; } = null!;
    }
}