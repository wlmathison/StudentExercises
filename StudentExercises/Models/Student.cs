using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Models
{
    public class Student : NSSPerson
    {
        /*public Student(string firstName, string lastName, string slackHandle, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Id = id;
        }
        */
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
