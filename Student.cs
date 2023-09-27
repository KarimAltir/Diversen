using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diversen
{
    internal class Student:StudentNaam
    {
        public int ID { get; set; }

        public string Naam { get; set; }

        //public string FamilieNaam { get; set; }

        //public string VoorNaam { get; set; }

        public DateTime Inschrijving { get; set; }

        static List<Student> students = new List<Student>();

        public Student() 
        { 
            students.Add(this);
        }

        public static Tuple<string, string> Name(int id)
        {
            Student student = null;
            foreach (Student s in students)
                if (s.ID == id)
                    student = s;

            return Tuple.Create(student.Voornaam, student.FamilieNaam);
        }

        public static StudentNaam StructNaam(int id)
        {
            Student student = null;
            foreach (Student s in students)
                if (s.ID == id)
                    student = s;
            StudentNaam sn = new StudentNaam();

            return new StudentNaam { Voornaam = student.Voornaam, FamilieNaam = student.FamilieNaam };
        }

        public override string ToString()
        {
            return "Id: " + ID + ";" + base.ToString();
        }

    }
    
    public class StudentNaam
    {
        public string Voornaam { get; set; }
        public string FamilieNaam { get; set; }

        public override string ToString()
        {
            return "Naam: " + Voornaam + " " + FamilieNaam;
        }

    }
}
