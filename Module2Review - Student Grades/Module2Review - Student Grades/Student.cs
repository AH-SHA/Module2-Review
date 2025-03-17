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
        public string Name { get; set; }
        public int ID { get; set; }

        public static List<double> Grades { get; set; } = new List<double> ();
        
        //public List <double> Grades {get; set;} 



        // 3 Methods for the Student Class

        public static void AddGrade(double grade)
        {
            Grades.Add(grade);
        }


        public static void AddGrades (params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public static double CalculateAverageGrade()
        {
            //var gCount = Grades.Count;

            if (Grades.Count == 0)
            {
                return 0;
            }
            else
            {
                double avgGrade = Queryable.Average(Grades.AsQueryable());
                return avgGrade;
            }


        }

    }
}
