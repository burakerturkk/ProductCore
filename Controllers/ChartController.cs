using Microsoft.AspNetCore.Mvc;
using ProductCore.Data;
using ProductCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCore.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }
        public List<Class1> ProList()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                proname = "Computer",
                stock = 150
            });
            cs.Add(new Class1()
            {
                proname = "LCD",
                stock = 75
            });
            cs.Add(new Class1()
            {
                proname = "USB Disk",
                stock = 220
            });
            return cs;
        }

        public IActionResult Index3()
        {
            return View();
        }

        public IActionResult VisualizeProductResult2()
        {
            return Json(ProductList());

        }

        public List<Class2> ProductList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new Context())
            {
                cs2 = c.Products.Select(x => new Class2
                {
                    productname = x.ProductDescription,
                    stock = x.ProductStock
                }).ToList();
            }
            return cs2;
        }

        public IActionResult Statistics()
        {
            Context c = new Context();
            var value1 = c.Products.Count();
            ViewBag.v1 = value1;

            var value2 = c.Categories.Count();
            ViewBag.v2 = value2;

            var PrId = c.Categories.Where(x => x.CategoryName == "Computers").Select(y => y.CategoryId).FirstOrDefault();
            //ViewBag.v = PrId;
            var value3 = c.Products.Where(x => x.CategoryId == PrId).Count();
            ViewBag.v3 = value3;

            var value4 = c.Products.Where(x => x.CategoryId == (c.Categories.Where(y => y.CategoryName == "Tablets").Select(y => y.CategoryId).FirstOrDefault())).Count();
            ViewBag.v4 = value4;

            var value5 = c.Products.Sum(x => x.ProductStock);
            ViewBag.v5 = value5;

            var value6 = c.Products.Where(x => x.CategoryId == c.Categories.Where(y => y.CategoryName == "MobilPhones").Select(z=>z.CategoryId).FirstOrDefault()).Count();
            ViewBag.v6 = value6;

            var value7 = c.Products.OrderByDescending(x => x.ProductStock).Select(y => y.ProductBrand).FirstOrDefault();
            ViewBag.v7 = value7;

            var value8 = c.Products.OrderBy(x => x.ProductStock).Select(y => y.ProductBrand).FirstOrDefault();
            ViewBag.v8 = value8;

            var value9 = c.Products.Average(x => x.ProductPrice);
            ViewBag.v9 = value9;

            var value10 = c.Categories.Where(x => x.CategoryName == "Computers").Select(y => y.CategoryId).FirstOrDefault();
            var value10p = c.Products.Where(y => y.CategoryId == value10).Sum(x => x.ProductStock);
            ViewBag.v10 = value10p;

            var value11 = c.Categories.Where(x => x.CategoryName == "Tablets").Select(y => y.CategoryId).FirstOrDefault();
            var value11p = c.Products.Where(y => y.CategoryId == value11).Sum(x => x.ProductStock);
            ViewBag.v11 = value11p;

            var value12 = c.Products.OrderByDescending(x => x.ProductPrice).Select(y => y.ProductBrand).FirstOrDefault();
            ViewBag.v12 = value12;

            return View(); 


        }
    }
}
