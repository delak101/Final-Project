using System.ComponentModel.DataAnnotations;

namespace Student_Manager.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Add Instructor Name")]

        public string Name { get; set; } = string.Empty;
        public int CourseId { get; set; }

        public Course Course { get; set; }

    }
}
