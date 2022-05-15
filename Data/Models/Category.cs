using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCore.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
           [Required(ErrorMessage ="Category Name Can Not Be Empty")]
           [StringLength(20)]
           [MinLength(4)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool Status { get; set; }
        public List<Product> Products { get; set; }


    }
}
