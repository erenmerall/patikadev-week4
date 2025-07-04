using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kitap Bilgileri");

        Book book1 = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

        Console.WriteLine($"Kitap Adı: {book1.BookName}");
        Console.WriteLine($"Yazar Adı: {book1.AuthorName}");
        Console.WriteLine($"Yazar Soyadı: {book1.AuthorSurname}");
        Console.WriteLine($"Sayfa Sayısı: {book1.PageCount}");
        Console.WriteLine($"Yayınevi: {book1.Publisher}");
        Console.WriteLine($"Kayıt Tarihi: {book1.RegistrationDate.ToShortDateString()}");
    }
}

class Book
{
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public string AuthorSurname { get; set; }
    public int PageCount { get; set; }
    public string Publisher { get; set; }
    public DateTime RegistrationDate { get; set; }

    // Default constructor
    public Book()
    {
        BookName = "Bilinmiyor";
        AuthorName = "Bilinmiyor";
        AuthorSurname = "Bilinmiyor";
        PageCount = 0;
        Publisher = "Bilinmiyor";
        RegistrationDate = DateTime.Now;
    }

    // Parametreli constructor
    public Book(string bookName, string authorName, string authorSurname, int pageCount, string publisher)
    {
        BookName = bookName;
        AuthorName = authorName;
        AuthorSurname = authorSurname;
        PageCount = pageCount;
        Publisher = publisher;
        RegistrationDate = DateTime.Now;
    }
}

// Class: Nesne üretmek için kullanılan, özellik ve davranışları tanımlayan bir şablondur.
// Property: Sınıftaki verileri tutmak ve dışarıdan erişilmesini sağlamak için kullanılan özelliklerdir.
// New: Bir sınıftan yeni bir nesne oluşturmak için kullanılan anahtar kelimedir.
// Constructor: Nesne oluşturulurken çalışan, başlangıç değerlerini atayan özel bir metottur. İsmi sınıf adıyla aynı olan ve dönüş tipi olmayan metotlardır.