using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Data;
using MyOnlineShop.Models;

namespace MyOnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProductRepository repositore = new ProductRepository();
        public ProductController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Guid id)
        {
            var product = repositore.GetById(id);
            if (product == null) return null;
            return View(product);
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
