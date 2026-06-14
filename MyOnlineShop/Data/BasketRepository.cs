using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data
{
    public class BasketRepository : IBasketRepository
    {
        private static List<Basket> Items = new List<Basket>() {
            new Basket("Айфон",1,120000)
        };
        public List<Basket> GetAll()
        {
            return Items;
        }
        public Basket? GetById(Guid id)
        {
            return Items.FirstOrDefault(i => i.Id == id);
        }
        public List<Basket> Add(Basket product)
        {
            Items.Add(product);
            return Items;
        }
        public List<Basket> Delete()
        {
            Items.Clear();
            return Items;
        }
        public List<Basket> Plus(Guid Id)
        {
            Items.FirstOrDefault(i => i.Id == Id).CountProduct += 1;
            return Items;
        }
        public List<Basket> Minus(Guid Id)
        {
            Items.FirstOrDefault(i => i.Id == Id).CountProduct -= 1;
            return Items;
        }
    }
}
