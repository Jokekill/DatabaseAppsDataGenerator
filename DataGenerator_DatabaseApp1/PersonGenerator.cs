using System;

namespace DataGenerator_DatabaseApp1
{
    public class PersonGenerator
    {
        private string[] surnames_s = {"Novak", "Novotny", "Coural", "Klepl"};
        private string[] surnames_t = { "Jezek", "Pelikan", "Dvorak", "Klazar" };
        private string[] firstnames = { "Josef", "Antonin", "Petr", "Jiri" };
        private string[] titles = { "Bc.", "Mgr.", "DiS.", "Phd.", "" };
        private string[] deparments = { "KSI", "D3S", "KAM"};



        private Random rand;

        public PersonGenerator(int seed)
        {
            rand = new Random(seed);
        }

        public  string RandomSurnameForStudent()
        {
            return surnames_s[rand.Next(surnames_s.Length)];
        }
        public string RandomSurnameForTeacher()
        {
            return surnames_t[rand.Next(surnames_t.Length)];
        }
        public  string RandomFirstname()
        {
            return firstnames[rand.Next(firstnames.Length)];
        }
        public  string RandomTitle()
        {
            return titles[rand.Next(titles.Length)];
        }
        public string RandomDepartment()
        {
            return deparments[rand.Next(deparments.Length)];
        }

        public  Person GeneratePerson_S(int ID)
        {
            Person p = new Person();
            p.ID = ID;
            p.surname = RandomSurnameForStudent();
            p.firstName = RandomFirstname();
            p.title = RandomTitle();
            return p;
        }
        public Person GeneratePerson_T(int ID)
        {
            Person p = new Person();
            p.ID = ID;
            p.surname = RandomSurnameForTeacher();
            p.firstName = RandomFirstname();
            p.title = RandomTitle();
            return p;
        }
    }
}
