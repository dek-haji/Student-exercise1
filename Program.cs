using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise classes = new Exercise();
            Exercise Dictionary = new Exercise();
            Exercise List = new Exercise();
            Exercise Inheritance = new Exercise();
            Exercise Interface = new Exercise();

            // Create 3, or more, cohorts.
            Cohort cohort27 = new Cohort();
            Cohort cohort28 = new Cohort();
            Cohort cohort29 = new Cohort();
            Cohort cohort30 = new Cohort();


            // Create 4, or more, students and assign them to one of the cohorts.
            Student Dek = new Student();
            Student Hellen = new Student();
            Student Jimmy = new Student();
            Student Dan = new Student();
            Dek.AssignCohort(cohort27);
            Hellen.AssignCohort(cohort28);
            Jimmy.AssignCohort(cohort29);
            Dan.AssignCohort(cohort30);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor Adam = new Instructor();
            Instructor Jissie = new Instructor();
            Instructor Bryan = new Instructor();
            Adam.assignCohort(cohort27);
            Jissie.assignCohort(cohort30);
            Bryan.assignCohort(cohort29);

            // Have each instructor assign 2 exercises to each of the students.
            Adam.AssignExercise(Dek, classes);
            Adam.AssignExercise(Dan, Inheritance);

            Jissie.AssignExercise(Jimmy, Interface);
            Jissie.AssignExercise(Hellen, Dictionary);
        }
    }
}
