/*
 * Created on Sun Dec 05 2021
 * Author:  Önder Ali ÖZDEMİR
 * onderozdemir184@gmail.com
 */


using System;
namespace _2___Interfaces_Gerçek_Hayat_Kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            

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

    class PersonManager{
        public void Add(IPerson person){
            System.Console.WriteLine(person.FirstName);
        }
    }

    class Worker:IPerson{
        public int Id { get; set; }
        public string FirstName {get; set; }
        public string LastName { get ; set; }
        public string WorkingTime { get; set; }
    }
}
