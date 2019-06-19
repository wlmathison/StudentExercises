using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Models
{
    public class Cohort
    {
        /*public Cohort(string name, int id)
        {
            Name = name;
            Id = id;
        }
        */
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
    }
}
