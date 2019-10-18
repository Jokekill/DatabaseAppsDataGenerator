namespace DataGenerator_DatabaseApp1
{
    public class Person
    {
        internal int ID;
        internal string firstName;
        internal string surname;
        internal string title;

        public string[] GetPersonInfo()
        {
            string[] s = new[] {ID.ToString(),firstName,surname,title};
            return s;
        }
    }

    public class Teacher : Person
    {
        private string department;
        public Teacher(string department, int ID, string fn, string sn, string title)
        {
            this.department = department;
            this.ID = ID;
            this.firstName = fn;
            this.surname = sn;
            this.title = title;
        }
        public string[] GetTeacherInfo()
        {
            string[] s = new[] { this.ID.ToString(), department };
            return s;
        }
    }

    public class Student : Person
    {
        internal int credits;

        public string[] GetStudentInfo()
        {
            string[] s = new[] { this.ID.ToString(), credits.ToString() };
            return s;
        }

        public Student(int credits, int ID, string fn, string sn, string title)
        {
            this.credits = credits;
            this.ID = ID;
            this.firstName = fn;
            this.surname = sn;
            this.title = title;
        }

    }
}