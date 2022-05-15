using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductCore.Data.Models;
using ProductCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ProductCore.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository productRepository = new ProductRepository();
        Context c = new Context();
        public IActionResult Index(int page = 1)
        {

            return View(productRepository.TList("Category").ToPagedList(page, 3));
        }
        [HttpGet]
        public IActionResult ProductAdd()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()

                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(Product p)
        {
            productRepository.TAdd(p);
            return RedirectToAction("Index");
        }


        public IActionResult ProductDelete(int id)
        {
            productRepository.TDelete(new Product { ProductId = id });
            return RedirectToAction("Index");
        }

        public IActionResult ProductGet(int id)
        {
            var x = productRepository.TGet(id);
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryId.ToString()

                                           }).ToList();
            ViewBag.v1 = values;
            Product p = new Product()
            {
                CategoryId = x.CategoryId,
                ProductId = x.ProductId,
                ProductBrand = x.ProductBrand,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                ProductDescription = x.ProductDescription,
                ProductImageURL = x.ProductImageURL
            };
            return View(p);
        }
        [HttpPost]
        public IActionResult ProductUpdate(Product p)
        {
            var x = productRepository.TGet(p.ProductId);
            x.ProductBrand = p.ProductBrand;
            x.ProductStock = p.ProductStock;
            x.ProductPrice = p.ProductPrice;
            x.ProductImageURL = p.ProductImageURL;
            x.ProductDescription = p.ProductDescription;
            x.CategoryId = p.CategoryId;
            productRepository.TUpdate(x);

            return RedirectToAction("Index");
        }
    }
}
