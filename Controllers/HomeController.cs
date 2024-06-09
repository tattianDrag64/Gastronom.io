using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductStore.Extensions;
using ProductStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStore.Controllers
{
        public class HomeController : Controller
        {

        public static List<Product> products = new List<Product>
{
    new Product { Id = 1, Name = "Cheddar Cheese", Category = "Dairy", SubCategory = "Cheese", ImageUrl = "/css/images/cheddar.jpg", Price = 5.99m, Quantity = 0 },
    new Product { Id = 3, Name = "Coca-Cola", Category = "Beverages", SubCategory = "Non-Alcoholic", ImageUrl = "/css/images/cola.jpg", Price = 1.99m, Quantity = 0 },
    new Product { Id = 4, Name = "Potatoes", Category = "Vegetables & Fruits", SubCategory = "Vegetables", ImageUrl = "/css/images/potatoes.jpg", Price = 0.99m, Quantity = 0 },
    new Product { Id = 5, Name = "Yogurt", Category = "Dairy", SubCategory = "Fermented Dairy", ImageUrl = "/css/images/yogurt.jpg", Price = 1.49m, Quantity = 0 },
    new Product { Id = 6, Name = "Milk", Category = "Dairy", SubCategory = "Milk", ImageUrl = "/css/images/milk.jpg", Price = 0.89m, Quantity = 0 },
    new Product { Id = 7, Name = "Parmesan", Category = "Dairy", SubCategory = "Cheese", ImageUrl = "/css/images/parmesan.jpg", Price = 6.99m, Quantity = 0 },
    new Product { Id = 8, Name = "Kefir", Category = "Dairy", SubCategory = "Fermented Dairy", ImageUrl = "/css/images/kefir.jpg", Price = 1.29m, Quantity = 0 },
    new Product { Id = 9, Name = "Curd", Category = "Dairy", SubCategory = "Fermented Dairy", ImageUrl = "/css/images/cottage_cheese.jpg", Price = 1.19m, Quantity = 0 },
    new Product { Id = 10, Name = "Pork", Category = "Meat & Fish", SubCategory = "Meat", ImageUrl = "/css/images/pork.jpg", Price = 5.49m, Quantity = 0 },
    new Product { Id = 11, Name = "BBQ Meat", Category = "Meat & Fish", SubCategory = "Meat", ImageUrl = "/css/images/bbq_meat.jpg", Price = 6.99m, Quantity = 0 },
    new Product { Id = 12, Name = "Salmon", Category = "Meat & Fish", SubCategory = "Fish", ImageUrl = "/css/images/salmon.jpg", Price = 8.99m, Quantity = 0 },
    new Product { Id = 13, Name = "Chicken Wings", Category = "Meat & Fish", SubCategory = "Meat", ImageUrl = "/css/images/chicken_wings.jpg", Price = 4.99m, Quantity = 0 },
    new Product { Id = 14, Name = "Sausages", Category = "Meat & Fish", SubCategory = "Sausages", ImageUrl = "/css/images/sausages.jpg", Price = 3.49m, Quantity = 0 },
    new Product { Id = 15, Name = "Apple Juice", Category = "Beverages", SubCategory = "Non-Alcoholic", ImageUrl = "/css/images/apple_juice.jpg", Price = 2.99m, Quantity = 0 },
    new Product { Id = 16, Name = "Wine", Category = "Beverages", SubCategory = "Alcoholic", ImageUrl = "/css/images/wine.jpg", Price = 10.99m, Quantity = 0 },
    new Product { Id = 17, Name = "Whiskey", Category = "Beverages", SubCategory = "Alcoholic", ImageUrl = "/css/images/whiskey.jpg", Price = 24.99m, Quantity = 0 },
    new Product { Id = 18, Name = "Beer", Category = "Beverages", SubCategory = "Alcoholic", ImageUrl = "/css/images/beer.jpg", Price = 1.99m, Quantity = 0 },
    new Product { Id = 19, Name = "Lemonade", Category = "Beverages", SubCategory = "Non-Alcoholic", ImageUrl = "/css/images/lemonade.jpg", Price = 1.49m, Quantity = 0 },
    new Product { Id = 20, Name = "Mushrooms", Category = "Vegetables & Fruits", SubCategory = "Mushrooms", ImageUrl = "/css/images/mushrooms.jpg", Price = 2.49m, Quantity = 0 },
    new Product { Id = 21, Name = "Corn", Category = "Vegetables & Fruits", SubCategory = "Vegetables", ImageUrl = "/css/images/corn.jpg", Price = 1.29m, Quantity = 0 },
    new Product { Id = 22, Name = "Apples", Category = "Vegetables & Fruits", SubCategory = "Fruits", ImageUrl = "/css/images/apples.jpg", Price = 1.99m, Quantity = 0 },
    new Product { Id = 23, Name = "Bananas", Category = "Vegetables & Fruits", SubCategory = "Fruits", ImageUrl = "/css/images/bananas.jpg", Price = 1.29m, Quantity = 0 },
    new Product { Id = 25, Name = "Bread", Category = "Bakery", SubCategory = "Bread", ImageUrl = "/css/images/bread.jpg", Price = 1.49m, Quantity = 0 },
    new Product { Id = 26, Name = "Croissant", Category = "Bakery", SubCategory = "Pastries", ImageUrl = "/css/images/croissant.jpg", Price = 2.49m, Quantity = 0 },
    new Product { Id = 27, Name = "Donut", Category = "Bakery", SubCategory = "Pastries", ImageUrl = "/css/images/donut.jpg", Price = 1.99m, Quantity = 0 },
    new Product { Id = 28, Name = "Apple Pie", Category = "Bakery", SubCategory = "Pastries", ImageUrl = "/css/images/apple_pie.jpg", Price = 3.49m, Quantity = 0 },
    new Product { Id = 29, Name = "Cherry Pie", Category = "Bakery", SubCategory = "Pastries", ImageUrl = "/css/images/cherry_pie.jpg", Price = 3.99m, Quantity = 0 },
    new Product { Id = 30, Name = "Milinka", Category = "Bakery", SubCategory = "Pastries", ImageUrl = "/css/images/milinka.jpg", Price = 2.99m, Quantity = 0 }
};


        private readonly ILogger<HomeController> _logger;

            public HomeController(ILogger<HomeController> logger)
            {
                _logger = logger;
            }

            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Products()
            {
                return View();
            }

            public IActionResult Cart()
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
