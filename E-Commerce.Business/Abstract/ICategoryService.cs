using System.Collections.Generic;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}