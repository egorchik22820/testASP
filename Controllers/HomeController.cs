using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product
            {
                ID = 1,
                ProdName = "Ноутбук",
                ProdLastName = "Мощный ноутбук для работы",
                ProdDiscription = "Мощный ноутбук с отличной производительностью.",
                ProdPrice = 50000,
                Images = "/images/laptop.jpg", // Убедитесь, что изображение существует по указанному пути
                Status = new Status(), // Замените на ваши актуальные значения для Status и других свойств
                TypesOfDevice = new TypesOfDevice(),
                Manufacturer = new Manufacturer() // Замените на актуальное значение
            },
            new Product
            {
                ID = 2,
                ProdName = "Смартфон",
                ProdLastName = "Современный смартфон",
                ProdDiscription = "Смартфон с отличными функциями.",
                ProdPrice = 30000,
                Images = "/images/smartphone.jpg", // Убедитесь, что изображение существует по указанному пути
                Status = new Status(), // Замените на ваши актуальные значения для Status и других свойств
                TypesOfDevice = new TypesOfDevice(),
                Manufacturer = new Manufacturer() // Замените на актуальное значение
            },
            // Добавьте больше продуктов здесь...
        };

            return View(products);
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
