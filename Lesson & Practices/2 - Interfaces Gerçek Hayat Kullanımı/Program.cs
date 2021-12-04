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
            /*
                Böyle kullanırsam yanlış olur. DAL katmanına iş katmanı aracılığı ile erişmem daha doğru. O yüzden DatabaseManager sınıfı oluşturuyorum.
            */
            // IDatabase database=new SqlServerDAL();
            // database.Add();

            DatabaseManager databaseManager=new DatabaseManager();
            databaseManager.Add(new SqlServerDAL());

        }
    }
    public interface IDatabase{

        void Add();
        void Delete();
        void Update();
    }

    public class SqlServerDAL : IDatabase
    {
        public void Add()
        {
            System.Console.WriteLine("Sql'e eklendi");
        }

        public void Delete()
        {
            System.Console.WriteLine("Sql' den silindi.");
        }

        public void Update()
        {
            System.Console.WriteLine("Sqlden update edildi.");
        }
    }
    public class MongoDAL : IDatabase
    {
        public void Add()
        {
            System.Console.WriteLine("Mongo ya eklendi");
        }

        public void Delete()
        {
            System.Console.WriteLine("Mongo dan silindi.");
        }

        public void Update()
        {
            System.Console.WriteLine("Mongo ya update edildi.");
        }
    }

    public class DatabaseManager{

        public void Add(IDatabase database){
            database.Add();
        }
    }
}
