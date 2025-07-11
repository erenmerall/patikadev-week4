using System;

namespace TechStoreApp
{
    // ABSTRACT BASE CLASS (Abstraction + Inheritance)
    abstract class BaseMachine
    {
        public DateTime ProductionDate { get; private set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        public BaseMachine()
        {
            ProductionDate = DateTime.Now;
        }

        // POLYMORPHISM: Sanal metot
        public virtual void PrintInfo()
        {
            Console.WriteLine("Üretim Tarihi: " + ProductionDate);
            Console.WriteLine("Seri Numarası: " + SerialNumber);
            Console.WriteLine("Ad: " + Name);
            Console.WriteLine("Açıklama: " + Description);
            Console.WriteLine("İşletim Sistemi: " + OperatingSystem);
        }

        // ABSTRACT METHOD: Ürün adını özelleştirme
        public abstract void GetProductName();
    }

    // TELEFON CLASS (Inheritance + Polymorphism)
    class Phone : BaseMachine
    {
        public bool IsLicensedInTurkey { get; set; }

        public override void GetProductName()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Name}");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("TR Lisanslı mı?: " + (IsLicensedInTurkey ? "Evet" : "Hayır"));
        }
    }

    // BİLGİSAYAR CLASS (Inheritance + Polymorphism + Encapsulation)
    class Computer : BaseMachine
    {
        private int _usbPortCount;

        public int UsbPortCount
        {
            get { return _usbPortCount; }
            set
            {
                if (value == 2 || value == 4)
                    _usbPortCount = value;
                else
                {
                    Console.WriteLine("Uyarı: USB girişi sadece 2 veya 4 olabilir. Varsayılan olarak -1 atanıyor.");
                    _usbPortCount = -1;
                }
            }
        }

        public bool HasBluetooth { get; set; }

        public override void GetProductName()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Name}");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("USB Giriş Sayısı: " + UsbPortCount);
            Console.WriteLine("Bluetooth Var mı?: " + (HasBluetooth ? "Evet" : "Hayır"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("Telefon üretmek için [1], Bilgisayar üretmek için [2] tuşlayınız:");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Phone phone = new Phone();

                    Console.Write("Seri Numarası: ");
                    phone.SerialNumber = Console.ReadLine();

                    Console.Write("Adı: ");
                    phone.Name = Console.ReadLine();

                    Console.Write("Açıklama: ");
                    phone.Description = Console.ReadLine();

                    Console.Write("İşletim Sistemi: ");
                    phone.OperatingSystem = Console.ReadLine();

                    Console.Write("TR Lisanslı mı? (e/h): ");
                    string trInput = Console.ReadLine().ToLower();
                    phone.IsLicensedInTurkey = trInput == "e";

                    Console.WriteLine("\nTelefon başarıyla üretildi!\n");
                    phone.GetProductName();
                    phone.PrintInfo();
                }
                else if (secim == "2")
                {
                    Computer pc = new Computer();

                    Console.Write("Seri Numarası: ");
                    pc.SerialNumber = Console.ReadLine();

                    Console.Write("Adı: ");
                    pc.Name = Console.ReadLine();

                    Console.Write("Açıklama: ");
                    pc.Description = Console.ReadLine();

                    Console.Write("İşletim Sistemi: ");
                    pc.OperatingSystem = Console.ReadLine();

                    Console.Write("USB Giriş Sayısı (2 veya 4): ");
                    int usbInput;
                    int.TryParse(Console.ReadLine(), out usbInput);
                    pc.UsbPortCount = usbInput;

                    Console.Write("Bluetooth var mı? (e/h): ");
                    string btInput = Console.ReadLine().ToLower();
                    pc.HasBluetooth = btInput == "e";

                    Console.WriteLine("\nBilgisayar başarıyla üretildi!\n");
                    pc.GetProductName();
                    pc.PrintInfo();
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 giriniz.");
                    continue;
                }

                Console.WriteLine("\nBaşka bir ürün üretmek istiyor musunuz? (e/h): ");
                string devam = Console.ReadLine().ToLower();

                if (devam != "e")
                {
                    continueProgram = false;
                    Console.WriteLine("\nİyi günler dileriz!");
                }

                Console.WriteLine("\n----------------------------\n");
            }
        }
    }
}
