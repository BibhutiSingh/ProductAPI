using Microsoft.EntityFrameworkCore;
using ProductAPI.Application.Common;
using ProductAPI.Core.Entities;

namespace ProductAPI.Application.Services 
{
    public class ProductService : BaseService<Product>
    {
        public ProductService(DbContext dbContext) : base(dbContext)
        {
        }
        public Guid CreateProduct()
        {
            return Guid.NewGuid();
        }
    }
}
