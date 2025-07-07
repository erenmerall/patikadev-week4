using System;

namespace Inheritance
{
    // Base sınıf
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void PrintNameSurname()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
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
            Console.WriteLine("-------------Öğrenci-------------"); // Yeni satır eklemek için
            Student ogr = new Student();
            ogr.Ad = "Eren";
            ogr.Soyad = "Meral";
            ogr.StudentNumber = "123456";
            ogr.PrintStudentInfo();
            Console.WriteLine("-------------Öğretmen-------------"); // Yeni satır eklemek için
            // Öğretmen nesnesi
            Teacher Teacher = new Teacher();
            Teacher.Ad = "Öğretmen";
            Teacher.Soyad = "Patika+";
            Teacher.Salary = 987654;
            Teacher.PrintTeacherInfo();
        }
    }
}
