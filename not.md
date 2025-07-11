**Property (Özellik)**
Sınıf içindeki verileri tanımlamak için kullanılır. Değişken gibi görünür ama genelde get ve set ile kontrol edilir.
public string Renk { get; set; }


**Class (Sınıf)**
Nesne tabanlı programlamada, nesneleri tanımlamak için kullanılan şablondur. Özellikler ve metotları barındırır.
public class Araba
{
    public string Marka;
    public string Model;
}

**Constructor (Yapıcı Metot)**
Bir sınıftan nesne oluşturulurken çalışan özel metottur. Genellikle başlangıç değerlerini atar.
public Araba(string marka)
{
    Marka = marka;
}


**Encapsulation (Kapsülleme)**
Verilerin dışarıdan doğrudan erişilmesini engelleyip kontrollü erişim sağlamaktır. Genelde private alan + public property ile yapılır.
private int kapiSayisi;
public int KapiSayisi
{
    get { return kapiSayisi; }
    set { if (value > 0) kapiSayisi = value; }
}


**Inheritance (Kalıtım)**
Bir sınıfın başka bir sınıftan özellik ve metotları miras almasıdır.
public class Tasit
{
    public string Marka;
}

public class Araba : Tasit
{
    public int KapiSayisi;
}


**Polymorphism (Çok Biçimlilik)**
Aynı metot isminin farklı sınıflarda farklı şekillerde çalışabilmesidir. Genelde virtual ve override ile kullanılır.
public class Hayvan
{
    public virtual void SesCikar() => Console.WriteLine("Hayvan sesi");
}

public class Kedi : Hayvan
{
    public override void SesCikar() => Console.WriteLine("Miyav");
}


**Abstraction (Soyutlama)**
Karmaşık yapıları gizleyip sadece gerekli olan detayları göstermektir. abstract class veya interface ile yapılır.
public abstract class Sekil
{
    public abstract double AlanHesapla();
}


**Interface (Arayüz)**
Sınıfların hangi metotları uygulaması gerektiğini belirten şablondur. İçinde sadece imzalar bulunur.
public interface ICalisabilir
{
    void Calis();
}
