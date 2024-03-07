namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constructor classı new lediğimizde çalışan bloktur... yapıcı blok

            // Bir sınıfı  newlediğimzde çalışmasını istediğimiz kodlar varsa constructor bloğunu kullanırız...

            Customer customer1 = new Customer { Id = 1, FirstName = "Yakup", LastName = "Aydoğan", City = "Ankara" };
            Customer customer2 = new Customer(2, "Engin", "Demiroğ", "Diyarbakır");

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
        }

        class Customer
        {
            public Customer() // inctance oluşturduğumuzda  default bu blok olarak çalışır
            {

            }

            // default  constructor PARATMETRESİ OLMAYAN CONSTRUCTOR
            public Customer(int id, string firstName, string lastName, string city)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                City = city;
            }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }

    }
}
