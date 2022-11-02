using Microsoft.EntityFrameworkCore;
using ProductAPI.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Application.Common
{
    public abstract class BaseService<T> where T : BaseAuditableEntity
    {
        protected DbContext _dbContext;
        public BaseService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().IgnoreAutoIncludes().ToListAsync<T>();
        }

        public IEnumerable<T> GetByFilter(Func<T, bool> filter, int rowLimit = 0)
        {
            if (rowLimit == 0)
            {
                return _dbContext.Set<T>().Where(filter);
            }
            else
            {
                return _dbContext.Set<T>().Where(filter).Take(rowLimit);
            }

        }
        public async Task<List<T>> GetByFilterAsync(Func<T, bool> filter)
        {
            return await Task.Run(() => { return _dbContext.Set<T>().AsQueryable<T>().Where(filter).ToList(); });

        }
        protected virtual IQueryable<T> GetAsQueryable()
        {
            return _dbContext.Set<T>().AsQueryable<T>();
        }

        public virtual async Task<T> GetByIdAsync(int Id)
        {
            return await _dbContext.Set<T>().FindAsync(Id);
        }
        public virtual void Add(T entity)
        {
            try
            {
                _dbContext.Set<T>().Add(entity);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public virtual async Task AddAsync(T entity)
        {
            try
            {
                await _dbContext.Set<T>().AddAsync(entity);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public virtual void AddRange(IEnumerable<T> entities)
        {
            try
            {
                _dbContext.Set<T>().AddRange(entities);
            }
            catch (Exception)
            {

                throw;
            }


        }
        public virtual async Task AddRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                await _dbContext.Set<T>().AddRangeAsync(entities);
            }
            catch (Exception)
            {

                throw;
            }


        }
        public virtual void Update(T entity)
        {
            try
            {
                var entityDB = _dbContext.Set<T>().Find(entity.Id);
                if (entityDB != null)
                {
                    entityDB = entity;
                    _dbContext.Set<T>().Update(entityDB);
                }

            }
            catch (Exception)
            {

                throw;
            }



        }
        public virtual async Task UpdateAsync(T entity)
        {
            try
            {
                var entityDB = await _dbContext.Set<T>().FindAsync(entity.Id);
                if (entityDB != null)
                {
                    entityDB = entity;
                    _dbContext.Set<T>().Update(entityDB);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public virtual void UpdateRange(IEnumerable<T> entities)
        {
            try
            {
                _dbContext.Set<T>().UpdateRange(entities);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public virtual void Delete(T entity)
        {
            try
            {


                var entityDB = _dbContext.Set<T>().Find(entity.Id);
                if (entityDB != null)
                {
                    entityDB = entity;
                    _dbContext.Set<T>().Remove(entityDB);
                }

            }
            catch (Exception)
            {

                throw;
            }



        }
        public virtual async Task DeleteAsync(T entity)
        {
            try
            {
                var entityDB = await _dbContext.Set<T>().FindAsync(entity.Id);
                if (entityDB != null)
                {
                    entityDB = entity;
                    _dbContext.Set<T>().Remove(entityDB);
                }

            }
            catch (Exception)
            {

                throw;
            }



        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            try
            {
                _dbContext.Set<T>().RemoveRange(entities);
            }
            catch (Exception)
            {

                throw;
            }


        }

      

    }
}
