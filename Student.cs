using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Cohort { get; set; }
        public Cohort CohortName { get; set; }

        public List<Exercise> ExerciseList = new List<Exercise>();

        public void AssignCohort( Cohort cohort)
        {
            cohort = CohortName;
        }

       
       

        // public  Student(string firstName, string lastName)
        // {
        //     FirstName = firstName;
        //     LastName = lastName;
        // }


    }
}