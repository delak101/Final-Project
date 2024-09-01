namespace Student_Manager.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;
        public HashSet<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();

    }
}
