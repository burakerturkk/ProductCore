



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCore.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductBrand { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public string ProductImageURL { get; set; }
        public int ProductStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
