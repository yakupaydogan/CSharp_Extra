namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, enum, boolean value types --> Stack'te tutulur..

            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = 100;
            //Console.WriteLine("Sayı 1: " + sayi1);

            // arrays, class, interface.. reference types

            //int[] sayilar1 = { 1, 2, 3 };
            //int[] sayilar2 = { 10, 20, 100 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayılar1[0] = " + sayilar1[0]);


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Yakup";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Test";
            Employee employee = new Employee();
            customer.CreditCardNumber = "1234567890";

            Person person3 = customer;
            customer.FirstName = "Salih";

            Console.WriteLine(((Customer)person3).CreditCardNumber); //boxing
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        // base class : Person 

        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}

// referance tiplerde değer eşitlemesi değil, adres eşitlemesi oluyor...
// base sınıfa onu inherit eden sınıfların referansını atayabiliriz...