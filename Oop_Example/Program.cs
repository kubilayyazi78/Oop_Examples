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

            CustomerManager customerManager = new CustomerManager(); //örnek olusturma instance alma

            customer.Id = 1;
            customer.FirstName = "Kubilay";
            customer.LastName = "Yazı";
            customer.NationalIdentity = "11111111111";

            customerManager.Save(customer);

            creditManager.Calculate();


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
            //public int Id

            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string NationalIdentity { get; set; }
            public string City { get; set; }
        }
        // Katmanlı Mimari Görevleri farklı katmanlarda yapıyoruz
        class CustomerManager
        {
            public void Save(Customer customer)
            {
                
            }
        }

      
    }
}
