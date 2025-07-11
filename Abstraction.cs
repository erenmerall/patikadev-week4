using System;

namespace CompanyApp
{
    // Soyut çalışan sınıfı
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public Employee(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        public abstract void Task();
    }

    // Yazılım geliştirici sınıfı
    class SoftwareDeveloper : Employee
    {
        public SoftwareDeveloper(string firstName, string lastName, string department)
            : base(firstName, lastName, department) { }

        public override void Task()
        {
            Console.WriteLine("Yazılım geliştirici olarak çalışıyorum.");
        }
    }

    // Proje yöneticisi sınıfı
    class ProjectManager : Employee
    {
        public ProjectManager(string firstName, string lastName, string department)
            : base(firstName, lastName, department) { }

        public override void Task()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
        }
    }

    // Satış temsilcisi sınıfı
    class SalesRepresentative : Employee
    {
        public SalesRepresentative(string firstName, string lastName, string department)
            : base(firstName, lastName, department) { }

        public override void Task()
        {
            Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bilgi alma
            Console.Write("Adınız: ");
            string firstName = Console.ReadLine();

            Console.Write("Soyadınız: ");
            string lastName = Console.ReadLine();

            Console.Write("Departman (Yazılım / Yönetim / Satış): ");
            string department = Console.ReadLine();

            // Departmana göre uygun sınıf oluşturma
            Employee employee;

            switch (department.ToLower())
            {
                case "yazılım":
                    employee = new SoftwareDeveloper(firstName, lastName, department);
                    break;
                case "yönetim":
                    employee = new ProjectManager(firstName, lastName, department);
                    break;
                case "satış":
                    employee = new SalesRepresentative(firstName, lastName, department);
                    break;
                default:
                    Console.WriteLine("Geçersiz departman girildi. Varsayılan olarak Yazılım Geliştirici atandı.");
                    employee = new SoftwareDeveloper(firstName, lastName, "IT");
                    break;
            }

            // Görev çıktısı
            employee.Task();

            // Ek bilgi
            Console.WriteLine($"Ben {employee.FirstName} {employee.LastName}, {employee.Department} departmanında çalışıyorum.");

        }
    }
}
