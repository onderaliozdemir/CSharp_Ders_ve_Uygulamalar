using System;

namespace _2___Interface_Son_Demo_Çoklu_İmplemantasyon
{
    class Program
    {
        // SOLID --> Interface Segregation(Ayırma)
        static void Main(string[] args)
        {
            /*
                SENARYO
                Bir şirkette çeşitli çalışanlar(WORKER) mevcut . (İŞÇİLER, YÖNETİCİLER, ROBOTLAR)

            */

            IWorker[] workers=new IWorker[3]{
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats=new IEat[2]{
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }

        public interface IWorker{

            void Work();
        }
        public interface IEat{
            void Eat();
        }
        public interface ISalary{
            void GetSalary();
        }
        public class Manager : IWorker, IEat, ISalary
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
            // public void Eat()
            // {
            //     throw new NotImplementedException();
            // }

            // public void GetSalary()
            // {
            //     throw new NotImplementedException();
            // }

            // public void Work()
            // {
            //     throw new NotImplementedException();
            // }
        }
        public class Worker : IWorker, IEat, ISalary
        {
            // public void Eat()
            // {
            //     throw new NotImplementedException();
            // }

            // public void GetSalary()
            // {
            //     throw new NotImplementedException();
            // }

            // public void Work()
            // {
            //     throw new NotImplementedException();
            // }
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
            // public void Eat() // ROBOT İÇİN GEÇERLİ DEĞİL.
            // {
            //     throw new NotImplementedException();
            // }

            // public void GetSalary() // ROBOT İÇİN GEÇERLİ DEĞİL.
            // {
            //     throw new NotImplementedException();
            // }
            // // Bu durum da programcılar genel de uyumsuz methodları boş bırakıyorlar. Ancak kullanım şekli sıkıntılı.
            // // Interfacelerin güzel yanlarından biri de birden fazla interface tanımlamak ve classlara atamak.
            // public void Work()
            // {
            //     throw new NotImplementedException();
            // }
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
