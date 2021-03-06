using System.Collections.Generic;
using bookpage.entity;

namespace bookpage.data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetPopularProducts();
    }
}