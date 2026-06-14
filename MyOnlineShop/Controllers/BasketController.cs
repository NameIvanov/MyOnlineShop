using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Data;
using MyOnlineShop.Models;

namespace MyOnlineShop.Controllers
{
    public class BasketController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IBasketRepository _basketRepository;
        public BasketController(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        public IActionResult Index()
        {
            var products = _basketRepository.GetAll();
            return View(products);
        }
        public IActionResult Add(string nameProduct, int costProduct)
        {
            _basketRepository.Add(new Basket(nameProduct, 1, costProduct));
            return RedirectToAction("Index");
        }
        public IActionResult Delete()
        {
            _basketRepository.Delete();
            return RedirectToAction("Index");
        }
        public IActionResult Plus(Guid Id)
        {
            _basketRepository.Plus(Id);
            return RedirectToAction("Index");
        }
        public IActionResult Minus(Guid Id)
        {
            _basketRepository.Minus(Id);
            return RedirectToAction("Index");
        }
        public IActionResult PlaceOrder()
        {
            var products = _basketRepository.GetAll();
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
