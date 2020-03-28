using NetCoreHRProject.DataAccess.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NetCoreHRProject.Entity.Common.Entities;
using NetCoreHRProject.Entity.Common.Constants;
using NetCoreHRProject.Entity.Base;

namespace NetCoreHRProject.DataAccess.Base
{
    public class BaseRepository<T> : IBaseRepositoryInterface<T> where T : BaseEntity, new()
    {
        MainApplicationDBContext dbContext;
        private readonly ILogger<T> logger;
        public BaseRepository(MainApplicationDBContext _dbContext, ILogger<T> _logger)
        {
            dbContext = _dbContext;
            logger = _logger;
        }

        public async Task<ResultEntity<T>> Delete(T entity)
        {
            ResultEntity<T> result = new ResultEntity<T>();

            try
            {

                using(var context = dbContext)
                {
                    context.Set<T>().Remove(entity);
                    await dbContext.SaveChangesAsync();
                    result.MessageArabic = CommonRepositoryMessages.DeleteSuccessMessage;
                    result.MessageEnglish = CommonRepositoryMessages.DeleteSuccessMessageEn;
                }              

            }
            catch (Exception ex)
            {
                result.Status = 1;
                result.MessageEnglish = CommonRepositoryMessages.ExceptionMessage;
                result.MessageArabic = CommonRepositoryMessages.ExceptionMessageEn;
                result.DetailsEnglish = ex.Message + Environment.NewLine + ex.StackTrace;
                logger.LogError(ex, ex.Message);
            }

            return result;
        }

        public async Task<ResultList<T>> FindAll(int pageIndex, int pageSize)
        {
            ResultList<T> result = new ResultList<T>();

            try
            {
                using (var context = dbContext)
                {
                    var count = await context.Set<T>().CountAsync();
                    result.ItemCount = count;
                    result.TotalPages = (int)Math.Ceiling((double)count / pageSize);
                    var skip = (pageIndex - 1) * pageSize;

                    var data = await dbContext.Set<T>().Skip(skip).Take(pageSize).OrderBy(a => a.CreatedOn).ToListAsync();
                   
                    if (data.Count > 0)
                        result.List = data;
                    else
                    {
                        result.Status = 3;
                        result.MessageEnglish = CommonRepositoryMessages.CannotFindAllMessageEN;
                        result.MessageArabic = CommonRepositoryMessages.CannotFindAllMessage;
                    }
                }
                   
            }
            catch (Exception ex)
            {
                result.Status = 1;
                result.MessageEnglish = CommonRepositoryMessages.ExceptionMessage;
                result.MessageArabic = CommonRepositoryMessages.ExceptionMessageEn;
                result.DetailsEnglish = ex.Message + Environment.NewLine + ex.StackTrace;
                logger.LogError(ex, ex.Message);
            }

            return result;
        }

        public async Task<ResultList<T>> FindAllItems()
        {
            ResultList<T> result = new ResultList<T>();

            try
            {
                using (var context = dbContext)
                {
                    var data = await context.Set<T>().ToListAsync();
                    if (data.Count > 0)
                        result.List = data;
                    else
                    {
                        result.Status = 3;
                        result.MessageEnglish = CommonRepositoryMessages.CannotFindAllMessageEN;
                        result.MessageArabic = CommonRepositoryMessages.CannotFindAllMessage;
                    }
                }

                  
            }
            catch (Exception ex)
            {

                result.Status = 1;
                result.MessageEnglish = CommonRepositoryMessages.ExceptionMessage;
                result.MessageArabic = CommonRepositoryMessages.ExceptionMessageEn;
                result.DetailsEnglish = ex.Message + Environment.NewLine + ex.StackTrace;
                logger.LogError(ex, ex.Message);
            }

            return result;
        }

        public async Task<ResultEntity<T>> FindOneByQuery(Expression<Func<T, bool>> expression)
        {
            ResultEntity<T> result = new ResultEntity<T>();
            try
            {

                using (var context = dbContext)
                {
                    var data = await context.Set<T>().Where(expression).FirstOrDefaultAsync();
                    if (data != null)
                    {
                        result.Entity = data;
                    }
                    else
                    {
                        result.Status = 3;
                        result.MessageArabic = CommonRepositoryMessages.CannotFindByIDMessage;
                        result.MessageEnglish = CommonRepositoryMessages.CannotFindByIDMessageEN;
                    }
                }

                  

            }
            catch (Exception ex)
            {
                result.Status = 1;
                result.MessageEnglish = CommonRepositoryMessages.ExceptionMessage;
                result.MessageArabic = CommonRepositoryMessages.ExceptionMessageEn;
                result.DetailsEnglish = ex.Message + Environment.NewLine + ex.StackTrace;
                logger.LogError(ex, ex.Message);
            }
            return result;
        }

        public async Task<ResultList<T>> FindByQuery(Expression<Func<T, bool>> expression)
        {
            ResultList<T> result = new ResultList<T>();
            try
            {

                using (var context = dbContext)
                {
                    var data = await context.Set<T>().Where(expression).ToListAsync();
                    if (data != null)
                    {
                        result.List = data;
                    }
                    else
                    {
                        result.Status = 3;
                        result.MessageArabic = CommonRepositoryMessages.CannotFindByIDMessage;
                        result.MessageEnglish = CommonRepositoryMessages.CannotFindByIDMessageEN;
                    }
                }

                   

            }
            catch (Exception ex)
            {
                result.Status = 1;
                result.MessageEnglish = CommonRepositoryMessages.ExceptionMessage;
                result.MessageArabic = CommonRepositoryMessages.ExceptionMessageEn;
                result.DetailsEnglish = ex.Message + Environment.NewLine + ex.StackTrace;
                logger.LogError(ex, ex.Message);
            }
            return result;
        }

        public async Task<ResultEntity<T>> Insert(T entity)
        {
            ResultEntity<T> result = new ResultEntity<T>();
            try
            {
                using (var context = dbContext)
                {
                    context.Set<T>().Add(entity);
                    await context.SaveChangesAsync();
                    result.MessageArabic = CommonRepositoryMessages.InsertSuccessMessage;
                    result.MessageEnglish = CommonRepositoryMessages.InsertSuccessMessageEn;
                    result.Entity = entity;
                }
                   

            }
            catch (Exception ex)
            {
                result.Status = 1;
                result.MessageEnglish = CommonRepositoryMessages.ExceptionMessage;
                result.MessageArabic = CommonRepositoryMessages.ExceptionMessageEn;
                result.DetailsEnglish = ex.Message + Environment.NewLine + ex.StackTrace;
                logger.LogError(ex, ex.Message);
            }
            return result;
        }

        public async Task<ResultEntity<T>> Update(T entity)
        {
            ResultEntity<T> result = new ResultEntity<T>();
            try
            {
                using (var context = dbContext)
                {
                    context.Set<T>().Update(entity);
                    await context.SaveChangesAsync();
                    result.MessageArabic = CommonRepositoryMessages.UpdateSuccessMessage;
                    result.MessageEnglish = CommonRepositoryMessages.UpdateSuccessMessageEn;
                }
                   

            }
            catch (Exception ex)
            {
                result.Status = 1;
                result.MessageEnglish = CommonRepositoryMessages.ExceptionMessage;
                result.MessageArabic = CommonRepositoryMessages.ExceptionMessageEn;
                result.DetailsEnglish = ex.Message + Environment.NewLine + ex.StackTrace;
                logger.LogError(ex, ex.Message);
            }
            return result;
        }

        public async Task<ResultEntity<int>> GetCount()
        {
            ResultEntity<int> result = new ResultEntity<int>();
            try
            {
                using (var context = dbContext)
                {
                    result.Entity = await context.Set<T>().CountAsync();
                }
            }
            catch (Exception ex)
            {

                result.Status = 1;
                result.MessageEnglish = CommonRepositoryMessages.ExceptionMessage;
                result.MessageArabic = CommonRepositoryMessages.ExceptionMessageEn;
                result.DetailsEnglish = ex.Message + Environment.NewLine + ex.StackTrace;
                logger.LogError(ex, ex.Message);
            }
            return result;
        }
    }
}
