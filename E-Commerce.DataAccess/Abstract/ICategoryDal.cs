using E_Commerce.Core.DataAccess;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom Operations  yani crud haricinde yeni metotlar buraya yazılacak.
    }
}