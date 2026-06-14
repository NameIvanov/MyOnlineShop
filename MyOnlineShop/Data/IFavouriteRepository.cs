using MyOnlineShop.Models;

namespace MyOnlineShop.Data
{
    public interface IFavouriteRepository
    {
        private static List<Product> Items;
        public List<Product> GetAll();
        public Product? GetById(Guid id);
        public List<Product> Add(string name, int cost, string description);
        public List<Product> Delete(Guid id);
        public List<Product> Clear();
    }
}
