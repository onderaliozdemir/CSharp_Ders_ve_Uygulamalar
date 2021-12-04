using System;

namespace _2___Interfaces_Neden_Kullanılır
{
    class Program
    {
        static void Main(string[] args)
        {

            #region !! INTERFACE' I EKSİK VEYA HATALI KULLANMA VE GEREKLİLİK SEBEBİ 
            /*
            PersonManager manager=new PersonManager();
            manager.Add(new Customer{
                    Id=1,
                    FirstName="Önder",
                    LastName="Özdemir",
                    Email="onderozdemir184@gmail.com"
            });

            Student student=new Student{
                Id=1,
                FirstName="Veli",
                LastName="Kan",
                Departmant="Bilgisayar Prog."
            };
            //manager.Add(student); // PROBLEM BU. Customer isteyen CustomerManager'a Student Göndermek istiyorum ancak Student kabul etmiyor.
            */
            #endregion

            PersonManager manager=new PersonManager();
            manager.Add(new Customer{
                    Id=1,
                    FirstName="Ali",
                    LastName="Özdemir",
                    Email="o@o.com"
            });

            manager.Add(new Student{
                Id=2,
                FirstName="Önder",
                LastName="Özdemir",
                Departmant="Bilgisayar Müh."
            });
        }
    }
    interface IPerson
    { 

        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName {get; set; }
        public string LastName { get ; set; }
        public string Email { get; set; }

    }

    class Student : IPerson
    { 
        public int Id { get; set; }
        public string FirstName {get; set; }
        public string LastName { get ; set; }
        public string Departmant { get; set; }
    }

    /*
    class PersonManager{ // İş katmanı sınıflarımız için kullanılır.

        public void Add(Customer customer){
            System.Console.WriteLine(customer.FirstName);
        }
    }
    */
    class PersonManager{
        public void Add(IPerson person){
            System.Console.WriteLine(person.FirstName);
        }
    }
}
