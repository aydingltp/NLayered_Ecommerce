﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public Product  Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
