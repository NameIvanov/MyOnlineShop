using MyOnlineShop.Models;

namespace MyOnlineShop.Data
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product("Айфон",90000,"iPhone 17 Pro"),
            new Product("Ноутбук",120000,"MacBook 12"),
            new Product("Наушники",55000,"airPods 5 Pro")
        };
        public List<Product> GetAll()
        {
            return products;
        }
        public Product? GetById(Guid id)
        {
            return products.FirstOrDefault(i => i.Id == id);
        }
    }
}
