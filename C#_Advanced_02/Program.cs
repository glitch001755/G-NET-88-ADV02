using C__Advanced_02.Resources;

namespace C__Advanced_02
{
    internal class Program
    {
        static void Main()
        {
            #region Adding Products 
            List<Product> catalog = new()
            {
                new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                new Product { Id=2,Name="Phone", Category="Electronics", Price=800, Stock=25 },
                new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
                new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
                new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                new Product { Id=9,Name="Headphones", Category="Electronics", Price=150}
            };
            #endregion

            #region All Electronics products
            // used Func<Product, bool> because i want passing the product as parameter and search for specific information in the product it finally return true or false (bool).
            List<Product> AllElectronicsProducts = Utility.SearchProducts(catalog, c => c.Category == "Electronics");
            Console.WriteLine("--- Electronics ---");
            foreach (Product product in AllElectronicsProducts)
            {
                Console.WriteLine($"{product.Name} - {product.Price:$0} (Stock: {product.Stock})  ");
            }
            #endregion

            #region Products cheaper than $50
            // used Func<Product, bool> because i want passing the product as parameter and search for specific information in the product it finally return true or false (bool).
            List<Product> ProductsCheaperThan50 = Utility.SearchProducts(catalog, c => c.Price < 50);
            Console.WriteLine("\n--- Under $50 --- ");
            foreach (Product product in ProductsCheaperThan50)
            {
                Console.WriteLine($"{product.Name} - {product.Price:$0} (Stock: {product.Stock})  ");
            }
            #endregion

            #region Products that are in stock
            // used Func<Product, bool> because i want passing the product as parameter and search for specific information in the product it finally return true or false (bool).
            List<Product> ProductsInStock = Utility.SearchProducts(catalog, c => c.Stock > 0);
            Console.WriteLine("\n--- Products Available In Stock --- ");
            foreach (Product product in ProductsInStock)
            {
                Console.WriteLine($"{product.Name} - {product.Price:$0} (Stock: {product.Stock})  ");
            }
            #endregion

            #region  Clothing products under $100
            // used Func<Product, bool> because i want passing the product as parameter and search for specific information in the product it finally return true or false (bool).
            List<Product> ClothingProductsUnder100 = Utility.SearchProducts(catalog, c => (c.Category == "Clothing" && c.Price < 100));
            Console.WriteLine("\n--- Clothing products under $100 --- ");
            foreach (Product product in ClothingProductsUnder100)
            {
                Console.WriteLine($"{product.Name} - {product.Price:$0} (Stock: {product.Stock})  ");
            }
            #endregion

            #region Print Reports
            // used Action<Product> because i want just print specific report about every product so i used one parameter of type Product and the return type void so used Action .
            Console.WriteLine("\n--- Short Report ---");
            Utility.PrintReport(catalog, c => Console.WriteLine($"{c.Name} - {c.Price:$0}"));
            Console.WriteLine("\n--- Detailed Report ---");
            Utility.PrintReport(catalog, c => Console.WriteLine($"[{c.Category}] {c.Name} |  Price:{c.Price:$0} | Stock:{c.Stock}"));
            #endregion

            #region Transform Products
            // used Func<Product, string> because i want store string data of every Product so passing one parameter of Product Type and Return string Store it at string list and return it so using Func because we have return . 
            Console.WriteLine("\n--- Summary List ---");
            List<string> summaryList = Utility.TransformProducts(catalog, c => $"{c.Name} ({c.Price:$0})");
            foreach (string summary in summaryList)
            {
                Console.WriteLine(summary);
            }

            Console.WriteLine("\n--- Price Labels ---");
            List<string> priceLabels = Utility.TransformProducts(catalog, c => $"{c.Name}: {(c.Price > 100 ? "Expensive!" : "Affordable")}");
            foreach (string label in priceLabels)
            {
                Console.WriteLine(label);
            }
            #endregion

            #region Filter Products
            // used Predicate<Product> because i want filter the list of products so i passing every product and apply the Filter logic and store the result at product list and return it .
            Console.WriteLine("--- Low-Stock Alert ---");
            List<Product> LowStockProducts = Utility.FilterProducts(catalog, c => c.Stock < 20);
            foreach (Product product in LowStockProducts)
            {
                Console.WriteLine($"[LOW STOCK] {product.Name} : only {product.Stock} left!");
            }
            #endregion

        }
    }
}
