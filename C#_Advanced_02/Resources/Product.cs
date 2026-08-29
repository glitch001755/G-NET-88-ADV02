namespace C__Advanced_02.Resources
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Category { get; set; } = default!;
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
