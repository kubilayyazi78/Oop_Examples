using System;

namespace Oop_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);

            int[] sayilar = new[] { 1, 2, 3 };
            int[] sayilar2 = new[] { 10, 22, 33 };
            sayilar = sayilar2;

            sayilar2[0] = 100;

            Console.WriteLine(sayilar[1]);

            
            CreditManager creditManager = new CreditManager();
            Customer customer = new Customer();

            CustomerManager customerManager = new CustomerManager(customer); //örnek olusturma instance alma


            Compony compony = new Compony();
            compony.Id = 100;
            Person person = new Person();
            customer.Id = 1;
            customer.FirstName = "Kubilay";
            customer.LastName = "Yazı";
            person.NationalIdentity = "11111111111";

            CustomerManager customerManager2 = new CustomerManager(new Compony());

            customerManager.Save();

            creditManager.Calculate();

            customerManager.Save();
            customerManager.Delete();
            Console.ReadKey();
        }
        class CreditManager
        {
            public void Calculate(){
                Console.WriteLine("Hesaplandı");
             }
            // public  void 
            public void Save()
            {
                Console.WriteLine("Kredi Verildi");
            }

        }

        //SOLID
        //S CLASS BİR İŞİ YAPABİLİR 

        class Customer
        {

            public Customer()
            {
                Console.WriteLine("müşteri nesnesi başlatıldı");
            }
            //public int Id

            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            
            public string City { get; set; }

         
        }

        class Person : Customer
        {
            public string NationalIdentity { get; set; }
        }

        class Compony :Customer
        {
            public string TaxNumber { get; set; }
        }

        // Katmanlı Mimari Görevleri farklı katmanlarda yapıyoruz
        class CustomerManager
        {
            private Customer _customer;
            public CustomerManager(Customer customer)
            {
                _customer = customer;
            }
            public void Save()
            {
                Console.WriteLine("müşteri kayıt " + _customer.FirstName);
            }

            public void Delete()
            {
                Console.WriteLine("müşteri silindi " + _customer.FirstName);
            }
        }

      
    }
}
