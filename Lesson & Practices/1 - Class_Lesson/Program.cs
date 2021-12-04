using System;

namespace Class_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CLASS GÖREVLERİ
            /* 
               - Class ları biz genel anlamda bizim yapmak istediğimiz işlemleri gruplara ayırmak için kullanırız. (en basit anlamda)
               - Property(Özellik) dediğimiz özellikleri tutmaktır.
             */

            /* 
                Bir classı kullanmak için onun örneğini oluşturmamız gerekir.
            */
            #endregion

            /* #region  1. New leme Yöntemi */
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Önder";
            customer.LastName = "Özdemir";
            customer.City = "İstanbul";
            /* #endregion */

            /* #region  !! 2. New leme Yöntemi  */
            Customer customer2 = new Customer
            {
                // CTRL + Space ile propertyler gelir.
                Id = 1,
                FirstName = "Veli",
                LastName = "Özdemir",
                City = "Ankara"
            };

            System.Console.WriteLine(customer2.FirstName);
            /* #endregion */
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
        }
    }

    class CustomerManager
    {// Müşteri ile ilgili işlemler..
        public void Add()
        {
            System.Console.WriteLine("Customer Added..");
        }

        public void Update()
        {
            System.Console.WriteLine("Customer Updated.");
        }

    }

    class ProductManager
    {// Product ile ilgili işlemler..
        public void Add()
        {
            System.Console.WriteLine("Product Added..");
        }

        public void Update()
        {
            System.Console.WriteLine("Product Update..");
        }
    }
    class Customer
    { // Customer Entity(varlık)

        /* PROPERTY
            Property bir müşterinin özelliklerini tuttuğumuz nesnedir. Genelde veritabanlarının kolon karşılıklarıdır.
        */
        public int Id { get; set; } // Property (Özellik) 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public string NotIncludeGetAndSetProp; // Böyle de tanımlanabilir ancak buna değer atanıp atanamaması veya okunup okunamamasına müdahale edemeyiz.
    }

}
