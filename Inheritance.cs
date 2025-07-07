using System;

namespace Inheritance
{
    // Base sınıf
    public class BaseKisi
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void PrintNameSurname()
        {
            Console.WriteLine($"Ad: {Name}, Soyad: {Surname}");
        }
    }

    // Student sınıfı - BaseKisi'den miras alıyor
    public class Student : BaseKisi
    {
        public string StudentNumber { get; set; }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Öğrenci No: {StudentNumber}");
            PrintNameSurname(); // Base sınıftan gelen metodu çağır
        }
    }

    // Teacher sınıfı - BaseKisi'den miras alıyor
    public class Teacher : BaseKisi
    {
        public decimal Salary { get; set; }

        public void PrintTeacherInfo()
        {
            Console.WriteLine($"Maaş: {Salary} TL");
            PrintNameSurname(); // Base sınıftan gelen metodu çağır
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci nesnesi
            Console.WriteLine("-------------Öğrenci-------------");
            Student ogr = new Student();
            ogr.Name = "Eren";
            ogr.Surname = "Meral";
            ogr.StudentNumber = "123456";
            ogr.PrintStudentInfo();
            Console.WriteLine("-------------Öğretmen-------------");
            // Öğretmen nesnesi
            Teacher Teacher = new Teacher();
            Teacher.Name = "Öğretmen";
            Teacher.Surname = "Patika+";
            Teacher.Salary = 987654;
            Teacher.PrintTeacherInfo();
        }
    }
}
