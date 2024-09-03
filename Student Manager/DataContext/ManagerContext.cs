using Student_Manager.Entities;
using Microsoft.EntityFrameworkCore;

namespace Student_Manager.DataContext
{
    public class ManagerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=StudentManagement;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure many-to-many relationship
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

            // Configure one-to-many relationship
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Course)
                .WithMany(c => c.Instructors)
                .HasForeignKey(i => i.CourseId);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


    }
}
