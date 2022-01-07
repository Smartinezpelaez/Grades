using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
   public class GradeBook
    {
        
        public GradeBook(string name = "there is no name" )
        {
            Name = name;
            grades = new List<float>();
        }
        public void AddGrade(float grade) {
            if (grade >=0 && grade <=1000 )
            {
                grades.Add(grade);
            }
           
        }

        public GradeStatics ComputeStatics ()
        {
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
        private string _name;

        public string Name
        {
          
            get {
                return _name;  
                 }

            set
            {
                if (_name != value)
                {
                    var oldvalue = _name;
                    _name = value;

                    if (namedChange != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.OldValue = oldvalue;
                        args.NewValue = value;
                        namedChange(this, args);
                    }
                   
                }
               
                //if (!string.IsNullOrEmpty(value))
                //{
                    
                //}

            }

        }

        public event NamedChangeDelegate namedChange;

       private  List<float>grades ;
    }
}
