﻿namespace Student_Manager.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CourseId { get; set; }

        public Course Course { get; set; }

    }
}
