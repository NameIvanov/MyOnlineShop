using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Models;

namespace MyOnlineShop.Data
{
    public class FavouriteRepository : IFavouriteRepository
    {
        private static List<Product> Items = new List<Product>() {
            //new Basket("Айфон",1,120000)
        };
        public List<Product> GetAll()
        {
            return Items;
        }
        public Product? GetById(Guid id)
        {
            return Items.FirstOrDefault(i => i.Id == id);
        }
        public List<Product> Add(string name,int cost,string description)
        {
            Items.Add(new Product(name,cost,description));
            return Items;
        }
        public List<Product> Delete(Guid id)
        {
            Items = Items.Where(i=> i.Id != id).ToList();
            return Items;
        }
        public List<Product> Clear()
        {
            Items.Clear();
            return Items;
        }
    }
}
