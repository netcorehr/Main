
using NetCoreHRProject.Entity.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NetCoreHRProject.DataAccess.Base
{
    public interface IBaseRepositoryInterface<T> where T : class, new()
    {
        Task<ResultEntity<T>> Insert(T entity);
        Task<ResultEntity<T>> Update(T entity);
        Task<ResultEntity<T>> Delete(T entity);
        Task<ResultEntity<T>> FindOneByQuery(Expression<Func<T, bool>> expression);
        Task<ResultList<T>> FindByQuery(Expression<Func<T, bool>> expression);
        Task<ResultList<T>> FindAllItems();
        Task<ResultList<T>> FindAll(int pageIndex, int pageSize);
        Task<ResultEntity<int>> GetCount();
    }
}
