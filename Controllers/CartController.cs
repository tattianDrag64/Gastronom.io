using Microsoft.AspNetCore.Mvc;
using ProductStore.Extensions;
using ProductStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductStore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("Cart") ?? new List<CartItem>();
            return View(cart);
        }

        [HttpPost]
        public IActionResult UpdateCart(int id, int quantity)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("Cart") ?? new List<CartItem>();
            var cartItem = cart.FirstOrDefault(ci => ci.Id == id);
            if (cartItem != null)
            {
                cartItem.Quantity = quantity;
                HttpContext.Session.SetObject("Cart", cart);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult PlaceOrder()
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>("Cart");
            if (cart != null)
            {
                HttpContext.Session.Remove("Cart");
            }
            return RedirectToAction("Index");
        }
    }
}
