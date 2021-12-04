using System;

namespace _2___Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /* #region INTERFACE NEDİR? */
            /*
                
                Temel operasyon temel nesne oluşturup tüm nesneleri ondan türetmek.
                Örnek Person, Customer ve Student ile örneklendirelim.
                NOT : Class gibi tanımlanır. Class yerine interface yazılır.
            */
            /* #endregion */
        }
    }
    interface IPerson
    { 

        /* #region INTERFACE NOTLARI: */
        /*
        Soyut Nesne (Abstract) : Tek başına hiçbir şey ifade etmez.

        Müşteri de öğrenci de bir insan dır. (Person) IPerson da tanımlanmış herşeyi
        hem Customer da hemde Student da kullanabilirim.
        
             - Interface içinde sadece imza bulunur.
             - public gibi erişim belirleyiciler olmaz. 
             - class'a implemente edilmiş tüm property ve methodlar class'da kullanılmak zorundadır.
             - imzalar dışında classa özel ek özellik veya method eklenebilir.
        */
        /* #endregion */
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson // Somut Nesne // -> : ile interface'i bir class'a implemente ediyoruz.
    {
        public int Id { get; set; }
        public string FirstName {get; set; }
        public string LastName { get ; set; }
        public string Email { get; set; } // Student class'ına kıyasla farklı bir özellik tanımladım.

    }

    class Student : IPerson // Somut Nesne
    { 
        public int Id { get; set; }
        public string FirstName {get; set; }
        public string LastName { get ; set; }
        public int Departmant { get; set; } // Student'a özel property
    }
}
