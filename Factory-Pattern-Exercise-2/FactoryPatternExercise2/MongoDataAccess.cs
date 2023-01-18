using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {     
        public void SaveData()
        {
            Console.WriteLine("Saving data from the Mongo database.....");
        }

        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine("Reading data from the Mongo database.....");
            Thread.Sleep(3000);
            Console.WriteLine();

            return new List<Product>()
            {
                new Product() { Name = "Samsung UHD Monitor", Price = 499.99 },
                new Product() { Name = "Dell XPS mouse", Price = 19.99 },
                new Product() { Name = "Samsung Wireless Keyboard", Price = 79.99 },
                new Product() { Name = "PS5", Price = 499.99 },
                new Product() { Name = "Clean Code", Price = 14.99 },
                new Product() { Name = "Gaming Chair", Price = 299.99 }


            };
        }
    }
}
