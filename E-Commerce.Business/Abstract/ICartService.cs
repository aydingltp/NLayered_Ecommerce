using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.Business.Abstract
{
    public interface ICartService
    {
        void AddCart(Cart cart,Product product);
        void RemoveFromCart(Cart cart,int producId);
        List<CartLine> List(Cart cart);
    }
}
