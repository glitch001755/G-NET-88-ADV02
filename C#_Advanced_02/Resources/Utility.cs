namespace C__Advanced_02.Resources
{
    public class Utility
    {
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> Filter)
        {
            List<Product> Result = new List<Product>();
            foreach (Product product in products)
            {
                if (Filter.Invoke(product))
                    Result.Add(product);
            }
            return Result;
        }
        public static void PrintReport(List<Product> products, Action<Product> printreport)
        {
            foreach (Product product in products)
            {
                printreport(product);
            }
        }
        public static List<string> TransformProducts(List<Product> products, Func<Product, string> Transformer)
        {
            List<string> results = new List<string>();
            foreach (var product in products)
            {
                results.Add(Transformer(product));
            }

            return results;
        }
        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> Filter)
        {
            List<Product> Result = new List<Product>();
            foreach (Product product in products)
            {
                if (Filter.Invoke(product))
                    Result.Add(product);
            }
            return Result;
        }
    }
}