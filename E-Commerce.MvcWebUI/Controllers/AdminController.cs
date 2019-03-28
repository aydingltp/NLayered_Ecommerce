using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Business.Abstract;
using E_Commerce.Entities.Concrete;
using E_Commerce.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.MvcWebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var productListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(productListViewModel);
        }

        public ActionResult Add()
        {
            var model =new ProductAddViewModel
            {
                Product = new Product(),
                Categories=_categoryService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempData.Add("message", "Product was successfully added");

            }

            return RedirectToAction("Add");
        }

        public ActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product=_productService.GetById(productId),
                Categories=_categoryService.GetAll()

            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                TempData.Add("message", "Product was successfully updated");

            }

            return RedirectToAction("Update");
        }

    }
}