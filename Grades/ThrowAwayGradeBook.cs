using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public ThrowAwayGradeBook(string name): base (name)
        {
            Console.WriteLine("ThrowAway Ctor");

        }

        public override void DoSomething()
        {
            
        }

        public override GradeStatics ComputeStatics() 
        {
            Console.WriteLine("Throwaway compute");
            float lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                lowest = Math.Min(lowest,grade);

            }
            grades.Remove(lowest);
            return base.ComputeStatics();
        }
    }
}
