using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review___Student_Grades
{
    class Student
    {
        //Class Properties
        public string Name { get; set}
        public int ID { get; set }

        public List<grades> grades = new List<grades> ();



        // 3 Methods for the Student Class

        public static void AddGrade(double grade)
        {
            Grades.Add(grade);
        }


        public static void AddGrades (params double[] grades)
        {
            grades.AddRange(grades);
        }


    }
}
