using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Grades
{
    public interface IGradeTracker: IEnumerable
        {
         void AddGrade(float grade);
         GradeStatics ComputeStatics();
         void WriteGrades(TextWriter textWriter);
         string Name { get; set; }
         event NamedChangeDelegate namedChange;
        void DoSomething();


    }
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract  GradeStatics ComputeStatics();
        public abstract void WriteGrades(TextWriter textWriter);
        public abstract IEnumerator GetEnumerator();
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
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

            }
        }
        private string _name;
        public event NamedChangeDelegate namedChange;
        public abstract void DoSomething();
       


    }
}
