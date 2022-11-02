using Microsoft.EntityFrameworkCore;
using ProductAPI.Application.Common;
using ProductAPI.Application.Services.Products.Models;
using ProductAPI.Core.Entities;
namespace ProductAPI.Application.Services.Products
{
    public class ProductService : BaseService<Product>
    {
        public ProductService(DbContext dbContext) : base(dbContext)
        {
        }
        public Guid CreateProduct(ProductCreate productCreate)
        {
            try
            {
                return Guid.NewGuid();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
