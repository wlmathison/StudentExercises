using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Models
{
    public class Instructor : NSSPerson
    {
        public string Specialty { get; set; }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
            exercise.Students.Add(student);
        }
    }
}
