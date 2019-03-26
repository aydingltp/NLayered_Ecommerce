using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
        public int PageCount { get; set; }
        public int CurrentCategory { get; set; }
        public int PageSize { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}
