﻿namespace Tap.School.Api.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
