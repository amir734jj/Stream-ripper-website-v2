using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.EntityFrameworkCore;
using Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Interfaces;


namespace DAL.Abstracts
{
    public abstract class AbstractBasicDal<T> : IBasicDal<T> where T : class, IBasicModel
    {
        /// <summary>
        /// Abstract to get IMapper
        /// </summary>
        /// <returns></returns>
        protected abstract IMapper GetMapper();
        
        /// <summary>
        /// Abstract to get database context
        /// </summary>
        /// <returns></returns>
        protected abstract DbContext GetDbContext();
        
        /// <summary>
        /// Abstract to get entity set
        /// </summary>
        /// <returns></returns>
        protected abstract DbSet<T> GetDbSet();

        /// <summary>
        /// Returns all entities
        /// </summary>
        /// <returns></returns>
        public virtual Task<List<T>> GetAll() => GetDbSet().ToListAsync();

        /// <summary>
        /// Returns an entity given the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual Task<T> Get(int id) => GetDbSet().FirstAsync(x => x.Id == id);

        /// <summary>
        /// Saves an instance
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public virtual async Task<T> Save(T instance)
        {
            GetDbSet().Persist().InsertOrUpdate(instance);
            await GetDbContext().SaveChangesAsync();
            return instance;
        }

        /// <summary>
        /// Deletes entity given the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<T> Delete(int id)
        {
            var instance = await GetDbSet().FirstAsync(x => x.Id == id);

            if (instance != null)
            {
                GetDbSet().Persist().Remove(instance);
                await GetDbContext().SaveChangesAsync();
                return instance;
            }

            return null;
        }

        /// <summary>
        /// Updates entity given the id and new instance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedInstance"></param>
        /// <returns></returns>
        public virtual async Task<T> Update(int id, T updatedInstance)
        {
            var instance = await GetDbSet().FirstAsync(x => x.Id == id);

            if (instance != null)
            {
                // Copy the fields
                GetDbSet().Persist().InsertOrUpdate(instance);
                await GetDbContext().SaveChangesAsync();
                return updatedInstance;
            }

            return null;
        }        
    }
}