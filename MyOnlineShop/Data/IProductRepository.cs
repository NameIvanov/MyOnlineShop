using MyOnlineShop.Models;

namespace MyOnlineShop.Data
{
    public interface IProductRepository
    {
        private static List<Product> products;
        public List<Product> GetAll();
        public Product? GetById(Guid id);
    }
}
