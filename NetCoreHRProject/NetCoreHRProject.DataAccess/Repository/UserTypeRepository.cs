using Microsoft.Extensions.Logging;
using NetCoreHRProject.DataAccess.Base;
using NetCoreHRProject.DataAccess.Interfaces;
using NetCoreHRProject.Entity.Common.Entities;
using NetCoreHRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreHRProject.DataAccess.Repository
{
    public class UserTypeRepository : IUserTypeRepository
    {
        IBaseRepositoryInterface<UserTypeEntity> repository;
        private readonly ILogger<UserTypeRepository> logger;
        public UserTypeRepository(IBaseRepositoryInterface<UserTypeEntity> _repository, ILogger<UserTypeRepository> _logger)
        {
            repository = _repository;
            logger = _logger;
        }
        public async Task<ResultEntity<UserTypeEntity>> Delete(UserTypeEntity entity)
        {
            return await repository.Delete(entity);
        }

        public async Task<ResultEntity<UserTypeEntity>> EnableDisableItem(UserTypeEntity entity)
        {

            ResultEntity<UserTypeEntity> result = new ResultEntity<UserTypeEntity>();

            result = await FindByID(entity.ID);
            if(result.Status==0)
            {
                result.Entity.IsEnabled = !result.Entity.IsEnabled;
                result = await Update(result.Entity);
            }

            return result;
        }

        public async Task<ResultList<UserTypeEntity>> FindAllActiveAndVisableItems()
        {
            return await repository.FindByQuery(a => a.IsEnabled == true && a.IsVisable == true);
        }

        public async Task<ResultList<UserTypeEntity>> FindAllItems()
        {
            return await repository.FindAllItems();
        }

        public async Task<ResultEntity<UserTypeEntity>> FindByCode(string code)
        {
            return await repository.FindOneByQuery(a => a.Code==code);
        }

        public async Task<ResultEntity<UserTypeEntity>> FindByID(Guid id)
        {
            return await repository.FindOneByQuery(a => a.ID == id);
        }

        public async Task<ResultEntity<UserTypeEntity>> HideShowItem(UserTypeEntity entity)
        {
            ResultEntity<UserTypeEntity> result = new ResultEntity<UserTypeEntity>();

            result = await FindByID(entity.ID);
            if (result.Status == 0)
            {
                result.Entity.IsVisable = !result.Entity.IsVisable;
                result = await Update(result.Entity);
            }

            return result;
        }

        public async Task<ResultEntity<UserTypeEntity>> Insert(UserTypeEntity entity)
        {
            return await repository.Insert(entity);
        }

        public async Task<ResultEntity<UserTypeEntity>> Update(UserTypeEntity entity)
        {
            return await repository.Update(entity);
        }

        public async Task<ResultEntity<int>> GetCount()
        {
            return await repository.GetCount();
        }
    }
}
