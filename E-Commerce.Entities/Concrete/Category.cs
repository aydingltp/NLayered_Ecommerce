using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using E_Commerce.Core.Entities;

namespace E_Commerce.Entities.Concrete
{
    public class Category:IEntity
    {
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

    }
}
