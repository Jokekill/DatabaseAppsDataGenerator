using System;

namespace DataGenerator_DatabaseApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("H");
            //Console.WriteLine(GenerateName(10));
            DataManager dm = new DataManager();
            dm.AddStudents(50,1);
            dm.InsertStudents("Student.out.v1");
            dm.AddTeachers(50, 101);
            dm.InsertTeachers("Teachers.out.v1");
            //SQLPrinter printer = new SQLPrinter("test.out");
            //string[] values = new[] {"JAN", "NOVY", "Mgr."};
            //printer.printInsert("PERSON", values);
            //printer.Close();
            Console.WriteLine("");



        }
        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }
    }
}

