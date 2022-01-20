using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    public class GradeStatics
    {
        public GradeStatics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public float AvergareGrade;
        public float HighestGrade;
        public float LowestGrade;

        public char LetterGrade
        {
            get
            {
                char result;
                if (AvergareGrade >= 90)
                {
                    result = 'A';
                }
                else if (AvergareGrade >= 80)
                {
                    result = 'B';
                }
                else if (AvergareGrade >= 70)
                {
                    result = 'C';
                }
                else if (AvergareGrade >= 60 && AvergareGrade < 70)
                {
                    result = 'D';
                }
                else
                {
                    result = 'F';
                }

                return result;
            }
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case 'A':
                        result = "Excellent";
                        break;

                    case 'B':
                        result = "Above Average";
                        break;

                    case 'C':
                        result = "Average";
                        break;

                    case 'D':
                        result = "Below Average";
                        break;
                    default:
                        result = "Fail";
                        break;
                }
                return result;

            }
       
             
        }
       
    }
}
