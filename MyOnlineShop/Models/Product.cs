namespace MyOnlineShop.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }

        public string Image { get; set; } = "/images/ProductCart.jpg";
        public Product(string name, int cost, string description)
        {
            Name = name;
            Cost = cost;
            Description = description;
            Id = Guid.NewGuid();
        }
    }
}