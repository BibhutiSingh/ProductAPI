using Microsoft.EntityFrameworkCore;
using ProductAPI.Application.Common;
using ProductAPI.Application.Services.Products;
using ProductAPI.Core.Entities;

namespace ProductAPI.Application.Services
{
    public class UnitOfWork : BaseUnitOfWork
    {

        public UnitOfWork(DbContext _dbContext) : base(_dbContext)
        {

        }
        #region Services

        public  ProductService ProductService => new ProductService(dbContext);
        #endregion


    }
}
