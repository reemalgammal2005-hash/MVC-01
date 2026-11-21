namespace MVC_01.Models
{
    public class Product
    {
        public int Id { get; internal set; }

        public class Products
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
