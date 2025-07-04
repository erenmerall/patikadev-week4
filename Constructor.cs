using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Default constructor\n");
        Baby baby1 = new Baby(); // default constructor çağrılır ve baby1 nesnesi oluşturulur
        Console.WriteLine($"Ad: {baby1.Name}");
        Console.WriteLine($"Soyad: {baby1.Surname}");
        Console.WriteLine($"Doğum Tarihi: {baby1.BirthDate.ToShortDateString()}");

        Console.WriteLine("\nParametreli constructor\n");
        Baby baby2 = new Baby("Eren", "Meral", DateTime.Now); // parametreli constructor çağrılır ve baby2 nesnesi oluşturulur
        Console.WriteLine($"Ad: {baby2.Name}");
        Console.WriteLine($"Soyad: {baby2.Surname}");
        Console.WriteLine($"Doğum Tarihi: {baby2.BirthDate.ToShortDateString()}");
        // ToShortDateString -> tarih bilgisini kısa formatta gösterir (gün/ay/yıl)
    }
}

class Baby
{
    // Properties
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }


    // default(parametresiz) constructor
    public Baby()
    {
        Console.WriteLine("Ingaaaa");
        Name = "Bilinmiyor";
        Surname = "Bilinmiyor";
        BirthDate = DateTime.Now;
    }

    // parametreli constructor
    public Baby(string name, string surname, DateTime birthDate)
    {
        Console.WriteLine("Ingaaaa");
        Name = name;
        Surname = surname;
        BirthDate = DateTime.Now;
    }
}