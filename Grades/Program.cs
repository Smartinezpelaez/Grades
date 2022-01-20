using System;
using System.IO;

namespace Grades
{
    class Program
    {
        //static void GiveBookAName(ref GradeBook book) {
        //    //book = new GradeBook();
        //    //book.Name = "The new Grade Book";
        //}

        //static void IncrementNumber(out int number) {
        //    number = 42;
        //}
        static void Main(string[] args)
        {
          IGradeTracker book = CreateGradeBook();            

            try
            {
                using (FileStream stream = File.Open("grades.txt", FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {


                    string line = reader.ReadLine();

                    //string[] lines = File.ReadAllLines("grades.txt");
                    //foreach (string line in lines)
                    while (line != null)
                    {
                        float grade = float.Parse(line);
                        book.AddGrade(grade);
                        line = reader.ReadLine();
                    }
                    reader.Close();
                    stream.Close();
                }

            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("Could not find the file grades.txt");
                return;
            }
            catch (UnauthorizedAccessException)
            {

                Console.WriteLine("no access");
                return;
            }
            //finally 
            //{
            //    if (reader != null)
            //    {
            //        reader.Close();

            //    }
            //    if (stream != null)
            //    {
            //        stream.Close();

            //    }

            //}
            foreach (float grade  in book)
            {
                Console.WriteLine(grade);
            }
            //book.DoSomething();
            //book.WriteGrades(Console.Out);

            try
            {
                //Console.WriteLine("Please enter a book name ");
                //book.Name = Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid name");
            }


            GradeStatics stats = book.ComputeStatics();
            Console.WriteLine(stats.AvergareGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine("{0} {1}", stats.LetterGrade, stats.Description);



            
        }

        private static IGradeTracker CreateGradeBook()
        {
            IGradeTracker book = new ThrowAwayGradeBook ("Steven´Books");
            return book; 
        }

        //private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine("****");
        //}

        //private static void OnNameChanged (object sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine("Name changed from {0} to {1} ", args.OldValue, args.NewValue);

        //}

        //private static void WriteBytes(int value)
        //{
        //    byte[] bytes = BitConverter.GetBytes(value);
        //    WriteBytearray(bytes);
        //}


        //private static void WriteBytes(float value)
        //{
        //    byte[] bytes = BitConverter.GetBytes(value);
        //    WriteBytearray(bytes);
        //}

        //private static void WriteBytearray(byte[] bytes)
        //{
        //    foreach (byte b in bytes)
        //    {
        //        Console.Write("0x{0:X} ", b);
        //    }
        //    Console.WriteLine();
        //}

        //private static void WriteName(params string[] names)
        //{
        //    foreach (string name in names)
        //    {
        //        Console.WriteLine(name);

        //    }

        //}


        //private static void AddGrades(float[] grades)
        //{
        //    if (grades.Length >=3)
        //    {
        //        grades[0] = 91f;
        //        grades[1] = 89.1f;
        //        grades[2] = 75f;

        //    }


        //}

        //private static void Immutable()
        //{
        //    string name = " Steven ";
        //    name = name.Trim();
        //    Console.WriteLine(name);

        //    DateTime date = new DateTime(2022, 01, 03);
        //    date = date.AddHours(25);
        //    Console.WriteLine(date);

        //}

        //private static void PassbyvalueAndRef()
        //{
        //    GradeBook g1 = new GradeBook();
        //    GradeBook g2 = g1;

        //    //g1 = new GradeBook();
        //    //g1.Name = "Steven martinez´s Book ";

        //    GiveBookAName(ref g2);
        //    Console.WriteLine(g2.Name);           
        //    int x1;
        //    IncrementNumber(out x1);
        //    Console.WriteLine(x1);
        //}
    }

   
}
