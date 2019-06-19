using StudentExercises.Data;
using StudentExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            List<Exercise> exercises = repository.GetAllExercises();

            PrintExerciseReport("All Exercises:", exercises);

            Console.WriteLine();

            List<Exercise> cSharpExercises = exercises.Where(e => e.Language == "C#").ToList();
            PrintExerciseReport("All C# Exercises:", cSharpExercises);

            Console.WriteLine();

            Exercise reusability = new Exercise
            {
                Name = "Reusability",
                Language = "React"
            };

            //repository.AddExercise(reusability);
            exercises = repository.GetAllExercises();
            PrintExerciseReport("All Exercises:", exercises);

            Console.WriteLine();
            List<Instructor> instructors = repository.GetAllInstructorsWithCohort();
            PrintInstructorReport("All instructors: ", instructors);

            Instructor steve = new Instructor
            {
                FirstName = "Steve",
                LastName = "Brownlee",
                SlackHandle = "coach",
                Specialty = "knowledge",
                CohortId = 1
            };
            //repository.AddInstructor(steve);

            Console.WriteLine();
            instructors = repository.GetAllInstructorsWithCohort();
            PrintInstructorReport("All instructors: ", instructors);

            Student billy = repository.GetAllStudentsWithCohort().Find(s => s.FirstName == "Billy");
            Exercise inheritance = repository.GetAllExercises().Find(e => e.Name == "Inheritance");
            Console.WriteLine($"{billy.FirstName}");
            Console.WriteLine($"{inheritance.Name}");
            repository.AssignExercise(billy, inheritance);
        }

        public static void PrintExerciseReport(string title, List<Exercise> exercises)
        {
            Console.WriteLine(title);
            exercises.ForEach(e => Console.WriteLine($"{e.Id}: {e.Name} - {e.Language}"));
        }
        public static void PrintInstructorReport(string title, List<Instructor> instructors)
        {
            Console.WriteLine(title);
            instructors.ForEach(i => Console.WriteLine($"{i.Id}: {i.FirstName} {i.LastName}, {i.Cohort.Name}"));
        }
    }
}
