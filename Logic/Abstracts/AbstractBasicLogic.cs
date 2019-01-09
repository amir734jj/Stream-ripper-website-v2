using System.Collections.Generic;
using System.Threading.Tasks;
using Dal.Interfaces;
using Logic.Interfaces;
using Models.Interfaces;

namespace Logic.Abstracts
{
    public abstract class AbstractBasicLogic<T> : IBasicLogic<T> where T : IBasicModel
    {
        /// <summary>
        /// Returns instance of basic DAL
        /// </summary>
        /// <returns></returns>
        protected abstract IBasicDal<T> GetBasicCrudDal();

        /// <summary>
        /// Call forwarding
        /// </summary>
        /// <returns></returns>
        public virtual Task<List<T>> GetAll() => GetBasicCrudDal().GetAll();

        /// <summary>
        /// Call forwarding
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual Task<T> Get(int id) => GetBasicCrudDal().Get(id);

        /// <summary>
        /// Call forwarding
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public virtual Task<T> Save(T instance) => GetBasicCrudDal().Save(instance);

        /// <summary>
        /// Call forwarding
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual Task<T> Delete(int id) => GetBasicCrudDal().Delete(id);

        /// <summary>
        /// Call forwarding
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedInstance"></param>
        /// <returns></returns>
        public virtual Task<T> Update(int id, T updatedInstance) => GetBasicCrudDal().Update(id, updatedInstance);
    }
}