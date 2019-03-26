using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using E_Commerce.Business.Abstract;
using E_Commerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal;

namespace E_Commerce.Business.Concrete
{
    public class CartService:ICartService
    {
        public void AddCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(i => i.Product.ProductId == product.ProductId);
            if (cartLine!=null)
            {
                cartLine.Quantity++;
                return;
            }
            else
            {
                cart.CartLines.Add(new CartLine{Product = product, Quantity = 1});
            }
        }

        public void RemoveFromCart(Cart cart, int producId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(i => i.Product.ProductId == producId));
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }
    }
}
