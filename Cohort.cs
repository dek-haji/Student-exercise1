using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string CohortName { get; set; }
        public Student FirstName { get; set; }

        public List<Student> StudentList = new List<Student>();
        
        public List<Instructor> InstructorList = new List<Instructor>();
        public void AssignCohort(Student student, string cohort)
        {
            student = FirstName;
            cohort = CohortName;
        }

    }
}