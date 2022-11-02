using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ProductAPI.Core.Entities;

namespace ProductAPI.Application.Common
{
    public abstract class BaseUnitOfWork : IDisposable
    {
        protected internal DbContext dbContext;
        public BaseUnitOfWork(DbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        
        #region DBOperations
        public IDbContextTransaction BeginTransaction()
        {
            return this.dbContext.Database.BeginTransaction();
        }
        public int SaveChanges()
        {
            return this.dbContext.SaveChanges();
        }
        public async Task<int> SaveChangesAsync()
        {
            return await this.dbContext.SaveChangesAsync();
        }
        #endregion
        #region Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && dbContext is not null)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
