using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Models;

namespace MyOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            string result = "";
            List<Product> products = new List<Product>() {
                new Product("Айфон",80000,"17 про"),
                new Product("Самсунг",70000,"190 про"),
                new Product("Айпад",140000,"12 про"),
                new Product("Аймак",240000,"макс версия")
            };
            foreach (var product in products)
            {
                result+=product.ToString();
            }
            return result;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
