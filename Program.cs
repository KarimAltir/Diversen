using Diversen;

Student student = new Student { Voornaam = "Joe", FamilieNaam = "Biden", ID = 1, Inschrijving = DateTime.Now };

string voornaam, familienaam;

Tuple<string, string> NaamVanStudent = Student.Name(1);

voornaam = NaamVanStudent.Item1;
familienaam = NaamVanStudent.Item2;

StudentNaam sn = Student.StructNaam(1);
voornaam = sn.Voornaam;
familienaam = sn.FamilieNaam;