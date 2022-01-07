using NUnit.Framework;
using System;

namespace Grades.Tests
{
 
    public class GradeBookTests
    {
        

        [Test]
        public void CalculatesHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(90f);
            book.AddGrade(50f);

            GradeStatics statics = book.ComputeStatics();

            Assert.AreEqual(90f, statics.HighestGrade);

        }

        [Test ]
        public void PassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "Not Set ";
            SetName(book);
            Assert.AreEqual("Not Set", book.Name);

        }
        void SetName(GradeBook book) {
            book.Name = "Not Set";
        }

        [Test]
        public void WriteAsByte(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            foreach (byte b in bytes)
            {
                Console.WriteLine("0x{0:x2}", b);
            }

        }
            
    }
}