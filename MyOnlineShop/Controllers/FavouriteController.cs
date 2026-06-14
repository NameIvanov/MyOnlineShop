using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Data;
using MyOnlineShop.Models;

namespace MyOnlineShop.Controllers
{
    public class FavouriteController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IFavouriteRepository _favouriteRepository;
        public FavouriteController(IFavouriteRepository favouriteRepository)
        {
            _favouriteRepository = favouriteRepository;
        }

        public IActionResult Index()
        {
            var products = _favouriteRepository.GetAll();
            return View(products);
        }
        public IActionResult Delete(Guid Id)
        {
            _favouriteRepository.Delete(Id);
            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            _favouriteRepository.Clear();
            return RedirectToAction("Index");
        }
        public IActionResult Add(string name,int cost,string description)
        {
            _favouriteRepository.Add(name,cost, description);
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
