using MyOnlineShop.Models;

namespace MyOnlineShop.Data
{
    public interface IBasketRepository
    {
        private static List<Basket> Items;
        public List<Basket> GetAll();
        public Basket? GetById(Guid id);
        public List<Basket> Add(Basket product);
        public List<Basket> Delete();
        public List<Basket> Plus(Guid Id);
        public List<Basket> Minus(Guid Id);
    }
}
