using System;
using System.Text;

namespace E_Commerce.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
