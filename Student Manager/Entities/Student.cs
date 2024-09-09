using System.ComponentModel.DataAnnotations;

namespace Student_Manager.Entities
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Add Student Name")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Add Student Age")]
        [Range(20, int.MaxValue, ErrorMessage = "Student Age must be over 19")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please Add Student Address")]
        public string Address { get; set; } = string.Empty;
        public HashSet<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
