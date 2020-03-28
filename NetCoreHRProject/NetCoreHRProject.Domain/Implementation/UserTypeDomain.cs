using Microsoft.Extensions.Logging;
using NetCoreHRProject.DataAccess.Interfaces;
using NetCoreHRProject.Domain.Interfaces;
using NetCoreHRProject.Entity.Common.Constants;
using NetCoreHRProject.Entity.Common.Entities;
using NetCoreHRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreHRProject.Domain.Implementation
{
    public class UserTypeDomain : IUserTypeDomain
    {
        IUserTypeRepository repository;
        private readonly ILogger<UserTypeEntity> logger;
        public UserTypeDomain(IUserTypeRepository _repository, ILogger<UserTypeEntity> _logger)
        {
            repository = _repository;
            logger = _logger;
        }

        public async Task<ResultEntity<UserTypeEntity>> Insert(UserTypeEntity entity)
        {
            ResultEntity<UserTypeEntity> result = new ResultEntity<UserTypeEntity>();
            var data = await FindByCode(entity.Code);
            if(data.Status==0)
            {
                result.Status = 2;
                result.MessageArabic = CommonDomainMessages.Err_CodeExist;
            }
            else if (data.Status==3)
            {
                result =  await repository.Insert(entity);
            }
            else
            {
                result.Status = data.Status;
                result.MessageArabic = data.MessageArabic;
                result.DetailsArabic = data.DetailsArabic;
            }
            return result;
        }

        public async Task<ResultEntity<UserTypeEntity>> Update(UserTypeEntity entity)
        {
            return await repository.Update(entity);
        }

        public async Task<ResultEntity<UserTypeEntity>> Delete(UserTypeEntity entity)
        {
            return await repository.Delete(entity);
        }

        public async Task<ResultEntity<UserTypeEntity>> HideShowItem(UserTypeEntity entity)
        {
            ResultEntity<UserTypeEntity> result = new ResultEntity<UserTypeEntity>();
            result = await repository.HideShowItem(entity);
            return result;
        }

        public async Task<ResultEntity<UserTypeEntity>> EnableDisableItem(UserTypeEntity entity)
        {
            ResultEntity<UserTypeEntity> result = new ResultEntity<UserTypeEntity>();
            result = await repository.EnableDisableItem(entity);
            return result;
        }

        public async Task<ResultList<UserTypeEntity>> FindAllItems()
        {
            return await repository.FindAllItems();
        }

        public async Task<ResultList<UserTypeEntity>> FindAllActiveAndVisableItems()
        {
            return await repository.FindAllActiveAndVisableItems();
        }


        public async Task<ResultEntity<UserTypeEntity>> FindByCode(string code)
        {
            return await repository.FindByCode(code);
        }

        public async Task<ResultEntity<UserTypeEntity>> FindByID(Guid id)
        {
            return await repository.FindByID(id);
        }


    }
}
