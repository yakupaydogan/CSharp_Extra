namespace Interfaces
{
    internal class Program
    {

        // interface new'lenemez..
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();

            customerManager.Add();
            employeeManager.Add();

        }

        class PersonManager
        {
            //implemented operation
            public void Add()
            {
                Console.WriteLine("Eklendi"); // her yerde ortak demek
            }
        }


        // interface ile bi şablon belirliyoruz..
        interface IPersonManager //interfacelerde isminin başına büyük I getirilir
        {
            //unimplemented operation
            void Add(); //default publictir... imzaam aynı müşteri için ekleme ayrı personel için ayrı
            void UpDate();
        }


        // inherits - class ----------------------- implements - interface
        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                // Müşteri ekleme kodları
                Console.WriteLine("Müşteri eklendi");
            }

            public void UpDate()
            {
                Console.WriteLine("Müşteri güncellendi");
            }
        }

        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                //Personel ekleme kodları
                Console.WriteLine("Personel eklendi.");
            }

            public void UpDate()
            {
                Console.WriteLine("Personel güncellendi");
            }
        }



    }
}
// Yazılımmda temel prensiplerden biri yeni özellik eklendiğinde mevcut kodlara dokunulmaz...
// Interfaceler onu implemnte eden sınıfın referans adresini tutabilirler...


