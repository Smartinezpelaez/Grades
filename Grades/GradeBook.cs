using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Grades
{
   public  class GradeBook : GradeTracker
    {
        
        public GradeBook(string name = "there is no name" )
        {
            Console.WriteLine("Geadebook Ctor");
            Name = name;
            grades = new List<float>();
        }
        public override void DoSomething()
        {
           
        }

        public override IEnumerator GetEnumerator() 
        {
            return grades.GetEnumerator();
        }
        public override void AddGrade(float grade) {
            if (grade >=0 && grade <=1000 )
            {
                grades.Add(grade);
            }
           
        }

       // public bool ThrowAwayLowest { get; set; }

        public override GradeStatics ComputeStatics ()
        {
            Console.WriteLine("Gradebook compute");
            GradeStatics stats = new GradeStatics();
            
            float sum = 0.0f;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;

                //if (grade > stats.HighestGrade )
                //{
                //    stats.HighestGrade = grade;
                //}
                // sum = sum + grade;

            }

            stats.AvergareGrade = sum / grades.Count;
            return stats;
        }

        public  override void WriteGrades(TextWriter textWriter )
        {
            textWriter.WriteLine("Grades ");
            //foreach (float grade  in grades)
            //{
            //    textWriter.WriteLine(grade);

            //}
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    textWriter.WriteLine(grades[i]);
            //}
            //textWriter.WriteLine("******");

            //for (int i = grades.Count -1 ; i >= 0; i--)
            //{
            //    textWriter.WriteLine(grades[i]);
            //}
            //int i = 0;
            //while (i < grades.Count)
            //{
            //    textWriter.WriteLine(grades[i]);
            //    i++;
            //}
            //textWriter.WriteLine("******");

            int i = 0;
            do
            {
                textWriter.WriteLine(grades[i]);
                i++;
            } while (i < grades.Count);
            textWriter.WriteLine("******");
        } 

       protected  List<float>grades ;
    }
}
