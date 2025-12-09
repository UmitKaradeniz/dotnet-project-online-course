using dotnet_project_online_course.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnet_project_online_course.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // ilişki tanımlama
        {
            base.OnModelCreating(modelBuilder);

            // User (Instructor) - Kurs İlişkisi
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Instructor) // kursu 1 kişi verir
                .WithMany(u => u.InstructorCourses) // eğitmenin birden fazla kursu olabilir
                .HasForeignKey(c => c.InstructorId) // fk
                .OnDelete(DeleteBehavior.Restrict); // eğitmen silindiğinde kurslar silinmesin çünkü kayıtlar önemli

            // 2. Kurs - Ders İlişkisi
            modelBuilder.Entity<Lesson>()
                .HasOne(l => l.Course)
                .WithMany(c => c.Lessons) 
                .HasForeignKey(l => l.CourseId)
                .OnDelete(DeleteBehavior.Cascade); // kurs silindiğinde dersler de silinsin

            // 3. User - Enrollment İlişkisi
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.User) // öğrenci
                .WithMany(u => u.Enrollments) 
                .HasForeignKey(e => e.UserId) 
                .OnDelete(DeleteBehavior.Cascade);

            // 4. Kurs - Enrollment İlişkisi
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Soft Delete 
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Course>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Lesson>().HasQueryFilter(l => !l.IsDeleted);
            modelBuilder.Entity<Enrollment>().HasQueryFilter(e => !e.IsDeleted);
        }
    }
}