using Microsoft.EntityFrameworkCore;
using ProductAPI.Application.Common;
using ProductAPI.Application.Services;
using ProductAPI.Core.Entities;

namespace ProductAPI.Application.Persistence
{
    public class UnitOfWork : BaseUnitOfWork
    {
       
        public UnitOfWork(DbContext _dbContext):base(_dbContext)
        {
           
        }
        #region Services

        public override ProductService ProductService => new ProductService(dbContext);
        #endregion


    }
}
