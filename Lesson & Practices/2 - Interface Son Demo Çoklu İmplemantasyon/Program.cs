using System;

namespace _2___Interface_Son_Demo_Çoklu_İmplemantasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                SENARYO
                Bir şirkette çeşitli çalışanlar(WORKER) mevcut . (İŞÇİLER, YÖNETİCİLER, ROBOTLAR)

            */
        }

        public interface IWorker{

            void Work(); // İŞCİ, YÖNETİCİ, ROBOT
            void Eat(); // İŞCİ, YÖNETİCİ 
            void GetSalary(); // İŞCİ, YÖNETİCİ 
        }
        public class Manager : IWorker
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        public class Worker : IWorker
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        public class Robot : IWorker
        {
            public void Eat() // ROBOT İÇİN GEÇERLİ DEĞİL.
            {
                throw new NotImplementedException();
            }

            public void GetSalary() // ROBOT İÇİN GEÇERLİ DEĞİL.
            {
                throw new NotImplementedException();
            }
            // Bu durum da programcılar genel de uyumsuz methodları boş bırakıyorlar. Ancak kullanım şekli sıkıntılı.
            // Interfacelerin güzel yanlarından biri de birden fazla interface tanımlamak ve classlara atamak.
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
