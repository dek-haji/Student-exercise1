using System;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Speciality { get; set; }
        public Cohort CohortName { get; set; }
        public Student name { get; set; }
        public Exercise ExerciseName { get; set; }

        public void assignCohort(string student, Cohort cohort)
        {
            student = FirstName;
            cohort = CohortName;
            //exercise.StudentList.Add(student);
        }

        internal void assignCohort(Cohort cohort)
        {
            cohort = CohortName;
        }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student = name;
            exercise = ExerciseName;
        }

    }

    }