using System.ComponentModel.DataAnnotations;

namespace Student_Manager.Entities
{
    public class StudentCourse
    {
        [Required(ErrorMessage = "Please select a student.")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Required(ErrorMessage = "Please select a course.")]
        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
