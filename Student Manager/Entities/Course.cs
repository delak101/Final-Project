namespace Student_Manager.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public HashSet<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public HashSet<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();

    }
}
