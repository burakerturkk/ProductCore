using Microsoft.AspNetCore.Mvc;
using ProductCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCore.ViewComponents
{
    public class ProductListByCategory : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
     
            ProductRepository productRepository = new ProductRepository();
            var productlist = productRepository.List(x => x.CategoryId == id);
            return View(productlist);
        }
    }
}
