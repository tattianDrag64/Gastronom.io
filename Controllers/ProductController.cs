using Microsoft.AspNetCore.Mvc;
using ProductStore.Extensions;
using ProductStore.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ProductStore.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> Products = new List<Product>
{
    new Product { Id = 1, Name = "Сир Чеддер", Category = "Молочні продукти", SubCategory = "Сири", ImageUrl = "/css/images/cheddar.jpg", Price = 149.00m, Quantity = 0 },
    new Product { Id = 2, Name = "Кока-Кола", Category = "Напої", SubCategory = "Безалкогольні", ImageUrl = "/css/images/cola.jpg", Price = 49.00m, Quantity = 0 },
    new Product { Id = 3, Name = "Картопля", Category = "Овочі та фрукти", SubCategory = "Овочі", ImageUrl = "/css/images/potatoes.jpg", Price = 25.00m, Quantity = 0 },
    new Product { Id = 4, Name = "Йогурт", Category = "Молочні продукти", SubCategory = "Кисломолочні продукти", ImageUrl = "/css/images/yogurt.jpg", Price = 37.00m, Quantity = 0 },
    new Product { Id = 5, Name = "Молоко", Category = "Молочні продукти", SubCategory = "Молоко", ImageUrl = "/css/images/milk.jpg", Price = 22.00m, Quantity = 0 },
    new Product { Id = 6, Name = "Пармезан", Category = "Молочні продукти", SubCategory = "Сири", ImageUrl = "/css/images/parmesan.jpg", Price = 174.00m, Quantity = 0 },
    new Product { Id = 7, Name = "Кефір", Category = "Молочні продукти", SubCategory = "Кисломолочні продукти", ImageUrl = "/css/images/kefir.jpg", Price = 32.00m, Quantity = 0 },
    new Product { Id = 8, Name = "Творог", Category = "Молочні продукти", SubCategory = "Кисломолочні продукти", ImageUrl = "/css/images/cottage_cheese.jpg", Price = 30.00m, Quantity = 0 },
    new Product { Id = 9, Name = "Свинина", Category = "М'ясо та риба", SubCategory = "М'ясо", ImageUrl = "/css/images/pork.jpg", Price = 137.00m, Quantity = 0 },
    new Product { Id = 10, Name = "М'ясо для шашлику", Category = "М'ясо та риба", SubCategory = "М'ясо", ImageUrl = "/css/images/bbq_meat.jpg", Price = 174.00m, Quantity = 0 },
    new Product { Id = 11, Name = "Лосось", Category = "М'ясо та риба", SubCategory = "Риба", ImageUrl = "/css/images/salmon.jpg", Price = 224.00m, Quantity = 0 },
    new Product { Id = 12, Name = "Курячі крильця", Category = "М'ясо та риба", SubCategory = "М'ясо", ImageUrl = "/css/images/chicken_wings.jpg", Price = 124.00m, Quantity = 0 },
    new Product { Id = 13, Name = "Сосиски", Category = "М'ясо та риба", SubCategory = "Сосиски", ImageUrl = "/css/images/sausages.jpg", Price = 87.00m, Quantity = 0 },
    new Product { Id = 14, Name = "Яблучний сік", Category = "Напої", SubCategory = "Безалкогольні", ImageUrl = "/css/images/apple_juice.jpg", Price = 75.00m, Quantity = 0 },
    new Product { Id = 15, Name = "Вино", Category = "Напої", SubCategory = "Алкогольні", ImageUrl = "/css/images/wine.jpg", Price = 274.00m, Quantity = 0 },
    new Product { Id = 16, Name = "Віскі", Category = "Напої", SubCategory = "Алкогольні", ImageUrl = "/css/images/whiskey.jpg", Price = 624.00m, Quantity = 0 },
    new Product { Id = 17, Name = "Пиво", Category = "Напої", SubCategory = "Алкогольні", ImageUrl = "/css/images/beer.jpg", Price = 49.00m, Quantity = 0 },
    new Product { Id = 18, Name = "Лимонад", Category = "Напої", SubCategory = "Безалкогольні", ImageUrl = "/css/images/lemonade.jpg", Price = 37.00m, Quantity = 0 },
    new Product { Id = 19, Name = "Гриби", Category = "Овочі та фрукти", SubCategory = "Гриби", ImageUrl = "/css/images/mushrooms.jpg", Price = 62.00m, Quantity = 0 },
    new Product { Id = 20, Name = "Кукурудза", Category = "Овочі та фрукти", SubCategory = "Овочі", ImageUrl = "/css/images/corn.jpg", Price = 32.00m, Quantity = 0 },
    new Product { Id = 21, Name = "Яблука", Category = "Овочі та фрукти", SubCategory = "Фрукти", ImageUrl = "/css/images/apples.jpg", Price = 49.00m, Quantity = 0 },
    new Product { Id = 22, Name = "Банани", Category = "Овочі та фрукти", SubCategory = "Фрукти", ImageUrl = "/css/images/bananas.jpg", Price = 32.00m, Quantity = 0 },
    new Product { Id = 23, Name = "Хліб", Category = "Випічка", SubCategory = "Хліб", ImageUrl = "/css/images/bread.jpg", Price = 37.00m, Quantity = 0 },
    new Product { Id = 24, Name = "Круасан", Category = "Випічка", SubCategory = "Випічка", ImageUrl = "/css/images/croissant.jpg", Price = 62.00m, Quantity = 0 },
    new Product { Id = 25, Name = "Пончик", Category = "Випічка", SubCategory = "Випічка", ImageUrl = "/css/images/donut.jpg", Price = 49.00m, Quantity = 0 },
    new Product { Id = 26, Name = "Яблучний пиріг", Category = "Випічка", SubCategory = "Випічка", ImageUrl = "/css/images/apple_pie.jpg", Price = 87.00m, Quantity = 0 },
    new Product { Id = 27, Name = "Вишневий пиріг", Category = "Випічка", SubCategory = "Випічка", ImageUrl = "/css/images/cherry_pie.jpg", Price = 99.00m, Quantity = 0 },
    new Product { Id = 28, Name = "Мілінка", Category = "Випічка", SubCategory = "Випічка", ImageUrl = "/css/images/milinka.jpg", Price = 75.00m, Quantity = 0 }
};

        public IActionResult Index(string search, string category)
        {
            var filteredProducts = Products.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                filteredProducts = filteredProducts.Where(p => p.Name.Contains(search, System.StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(category))
            {
                filteredProducts = filteredProducts.Where(p => p.Category == category);
            }

            return View(filteredProducts.ToList());
        }

        [HttpPost]
        public IActionResult AddToCart(int id, int quantity)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                var cart = HttpContext.Session.GetObject<List<CartItem>>("Cart") ?? new List<CartItem>();

                var cartItem = cart.FirstOrDefault(c => c.Id == product.Id);
                if (cartItem == null)
                {
                    cart.Add(new CartItem
                    {
                        Id = product.Id,
                        ProductName = product.Name,
                        Quantity = quantity,
                        Price = product.Price
                    });
                }
                else
                {
                    cartItem.Quantity += quantity;
                }

                HttpContext.Session.SetObject("Cart", cart);
            }
            return RedirectToAction("Index");
        }
    }
}
