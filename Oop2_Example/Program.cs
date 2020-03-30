using System;

namespace Oop2_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //ıoc container depency injection
            CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
            customerManager.GiveCredit();
            Console.ReadLine();
        }


        class CreditManager
        {
            public void Calculate(int creditType)
            {//sonar qube if sayısına bakıp zaafiyetleri söyler 
                if (creditType==1)// kredi çeşitleri
                {

                }
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
        interface ICreditManager
        {
            void Calculete();
            void Save();
        }

        abstract class BaseCreditManager : ICreditManager
        {
            public abstract void Calculete();

            public virtual void Save()
            {
                Console.WriteLine("kaydedildi");
            }
        }
        //dry kavramı
        class TeacherCreditManager :BaseCreditManager , ICreditManager
        {
            public override void Calculete()
            {

                //hesaplama
                Console.WriteLine("öğr kredisi");
            }

    
        }
        class MilitaryCreditManager : ICreditManager
        {
            public void Calculete()
            {
                Console.WriteLine("asker kredisi");
            }

            public void Save()
            {
                throw new NotImplementedException();
            }
        }
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

        class Compony : Customer
        {
            public string TaxNumber { get; set; }
        }

        // Katmanlı Mimari Görevleri farklı katmanlarda yapıyoruz
        class CustomerManager
        {
            private Customer _customer;
            private ICreditManager _creditManager;
            public CustomerManager(Customer customer, ICreditManager creditManager)
            {
                _customer = customer;
                _creditManager =creditManager;
            }
            public void Save()
            {
                Console.WriteLine("müşteri kayıt " + _customer.FirstName);
            }

            public void Delete()
            {
                Console.WriteLine("müşteri silindi " + _customer.FirstName);
            }

            public void GiveCredit()
            {
                _creditManager.Calculete();
                Console.WriteLine("hesaplandu give");

            }
        }
    }
}
