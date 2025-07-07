using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Arabanın bilgileri");

        Car car = new Car();
        car.Brand = "Renault";
        car.Model = "Clio 5";
        car.Color = "Kırmızı";
        car.DoorCount = 4; // Geçerli değer

        Console.WriteLine($"Marka: {car.Brand}");
        Console.WriteLine($"Model: {car.Model}");
        Console.WriteLine($"Renk: {car.Color}");
        Console.WriteLine($"Kapı Sayısı: {car.DoorCount}");
    }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    private int _doorCount;

    // encapsulation ile kapı sayısını kontrol eden property
    // Kapı sayısı yalnızca 2 veya 4 olabilir, aksi halde -1
    public int DoorCount
    {
        get { return _doorCount; }
        set
        {
            if (value == 2 || value == 4)
            {
                _doorCount = value;
            }
            else
            {
                Console.WriteLine("Kapı sayısı yalnızca 2 veya 4 olabilir. Varsayılan olarak -1 atanıyor.");
                _doorCount = -1;
            }
        }
    }
}
