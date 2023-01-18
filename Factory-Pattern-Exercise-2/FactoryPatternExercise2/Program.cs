namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please tell me the type of database you would like to" +
                " access. You may select from the \'MySQL\', \'Mongo\', or \'List\' databases.");

            var databaseType = Console.ReadLine().ToLower();

            IDataAccess dataType = DataAccessFactory.GetDataAccess(databaseType);
            List<Product> products = dataType.LoadData();

            foreach(var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} and the price is \'${product.Price}\'.");
                Console.WriteLine();
            }

            dataType.SaveData();

        }
    }
}
