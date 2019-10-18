using System;
using System.Collections.Generic;
using System.Text;

namespace DataGenerator_DatabaseApp1
{
    class DataManager
    {
        List<Person> persons = new List<Person>();
        List<Person> students = new List<Person>();
        List<Person> teachers = new List<Person>();
        public void AddPersons(int amount, int firstID)
        {
            PersonGenerator pg = new PersonGenerator(1);
            for (int i = 0; i < amount; i++)
            {
                persons.Add(pg.GeneratePerson_T(i + firstID));
            }
        }

        public void InsertPersons(string table, string output)
        {
            SQLPrinter printer = new SQLPrinter(output);
            foreach (var p in persons)
            {
                printer.printInsert(table,p.GetPersonInfo());
            }
            printer.Close();

        }
        public void AddStudents(int amount, int firstID)
        {
            PersonGenerator pg = new PersonGenerator(1);
            for (int i = 0; i < amount; i++)
            {
                Person s =  pg.GeneratePerson_S(i + firstID);
                Student student = new Student(0,s.ID,s.firstName,s.surname,s.title); //TODO maybe add some randomness
                students.Add(student);
            }
        }
        public void InsertStudents( string output)
        {
            SQLPrinter printer = new SQLPrinter(output);
            foreach (var s in students)
            {
                printer.printInsert("PERSON", s.GetPersonInfo());
                printer.printInsert("STUDENT", ((Student)s).GetStudentInfo());
            }
            printer.Close();
        }
        public void AddTeachers(int amount, int firstID)
        {
            PersonGenerator pg = new PersonGenerator(1);
            for (int i = 0; i < amount; i++)
            {
                Person s = pg.GeneratePerson_T(i + firstID);
                Teacher teacher = new Teacher(pg.RandomDepartment(), s.ID, s.firstName, s.surname, s.title); 
                teachers.Add(teacher);
            }
        }
        public void InsertTeachers(string output)
        {
            SQLPrinter printer = new SQLPrinter(output);
            foreach (var t in teachers)
            {
                printer.printInsert("PERSON", t.GetPersonInfo());
                printer.printInsert("TEACHER", ((Teacher)t).GetTeacherInfo());
            }
            printer.Close();
        }




    }
}
