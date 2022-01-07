using System;


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

            //Arrays();
            //Immutable();
            // PassbyvalueAndRef();


            GradeBook book = new GradeBook("Steven´Books");
            book.AddGrade(91f);
            book.AddGrade(45.6f);
            book.AddGrade(75);

            GradeStatics stats = book.ComputeStatics();


            //int number = 20;
            //WriteBytes(number);
            //WriteBytes(stats.AvergareGrade);
            // book.Name = "";

            //book.namedChange = new NamedChangeDelegate(OnNameChanged);
            //book.namedChange += OnNameChanged;
            //book.namedChange += OnNameChanged;
            //book.namedChange += OnNameChanged2;
            //book.namedChange -= OnNameChanged;
            //book.Name = "Vanessa´s Book";
            //WriteName(book.Name);

            Console.WriteLine("La nota promedio es " + stats.AvergareGrade);
            Console.WriteLine("La nota mas alta es " + stats.HighestGrade);
            Console.WriteLine("la noa mas baja es " + stats.LowestGrade);
            Console.WriteLine("{0} {1}", stats.LetterGrade , stats.Description);
      

            //GradeBook book1 = book;
            //book1.AddGrade(75f);

            //Console.WriteLine();
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
