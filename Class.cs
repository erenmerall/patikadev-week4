using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Person student1 = new Person()
        {
            Name = "Eren",
            Surname = "Meral",
            BirthDate = new DateTime(2002, 07, 02)
        };
        Person student2 = new Person()
        {
            Name = "student2Name",
            Surname = "student2Surname",
            BirthDate = new DateTime(2025, 07, 02)
        };
        Person student3 = new Person()
        {
            Name = "student3Name",
            Surname = "student3Surname",
            BirthDate = new DateTime(2025, 01, 01)
        };
        Person teacher1 = new Person()
        {
            Name = "teacher1Name",
            Surname = "teacher1Surname",
            BirthDate = new DateTime(2025, 01, 01)
        };
        Person teacher2 = new Person()
        {
            Name = "teacher2Name",
            Surname = "teacher2Surname",
            BirthDate = new DateTime(2025, 01, 01)
        };
        Person teacher3 = new Person()
        {
            Name = "teacher3Name",
            Surname = "teacher3Surname",
            BirthDate = new DateTime(2025, 01, 01)
        };

        List<Person> people = new List<Person> { student1, student2, student3, teacher1, teacher2, teacher3 };

        Console.WriteLine("Kişiler");
        Console.WriteLine("---------------------");
        foreach (var person in people)
        {
            Console.WriteLine($"Ad: {person.Name}");
            Console.WriteLine($"Soyad: {person.Surname}");
            Console.WriteLine($"Doğum Tarihi: {person.BirthDate.ToShortDateString()}");
            Console.WriteLine("---------------------");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}