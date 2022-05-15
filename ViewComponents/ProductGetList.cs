using Microsoft.AspNetCore.Mvc;
using ProductCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCore.ViewComponents
{
    public class ProductGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ProductRepository productRepository = new ProductRepository();
            var productlist = productRepository.TList();
            return View(productlist);
        }
    }
}
