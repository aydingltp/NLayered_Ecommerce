using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using E_Commerce.Core.Entities;

namespace E_Commerce.Entities.Concrete
{
    public class Product:IEntity    
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        [Required]
        [Display(Name = "Units in Stock")]
        public short UnitsInStock { get; set; } 


    }
}
