using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Core.DataAccess;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Custom Operations  yani crud haricinde yeni metotlar buraya yazılacak.
    }
}
