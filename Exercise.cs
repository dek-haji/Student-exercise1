using System;

namespace StudentExercises
{
    public class Exercise
    {       
        public string ExerciseName {get; set; }
        public string ExerciseType {get; set; }
        public Student FirstName { get;  set; }

        public void AssignExercise(Student student, string exercise){
            student = FirstName;
            exercise = ExerciseName;
        }

      
    }
}