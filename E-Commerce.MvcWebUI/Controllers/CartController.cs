using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Business.Abstract;
using E_Commerce.MvcWebUI.Models;
using E_Commerce.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddCart(cart,productToBeAdded);

            _cartSessionService.SetCart(cart);
            TempData.Add("message",String.Format("Your product, {0}, was succesfully added to the cart!",productToBeAdded.ProductName));
           return RedirectToAction("Index", "Product");

        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel=new CartListViewModel()
            {
                Cart=cart,  
            };
            return View(cartListViewModel);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart,productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your product  was succesfully removed from the cart!"));
            return RedirectToAction("List");

        }

    }
    
}