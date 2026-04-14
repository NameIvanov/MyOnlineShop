using MyOnlineShop.Models;

namespace MyOnlineShop.Data
{
    public class BasketRepository
    {
        private static List<Product> Items = new List<Product>() {
            new Product("Айфон",90000,"iPhone 17 Pro"),
            new Product("Ноутбук",120000,"MacBook 12"),
            new Product("Наушники",55000,"airPods 5 Pro")
        };
        public List<Product> GetAll()
        {
            return Items;
        }
        public Product? GetById(Guid id)
        {
            return Items.FirstOrDefault(i => i.Id == id);
        }
        public static void Add(Product product)
        {
            Items.Add(product);
        }
    }
}
