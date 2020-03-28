using Microsoft.Extensions.Logging;
using NetCoreHRProject.DataAccess.Base;
using NetCoreHRProject.Domain.Interfaces;
using NetCoreHRProject.Entity.Common.Constants;
using NetCoreHRProject.Entity.Common.Entities;
using NetCoreHRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIPHRHelperCoreLatest.Domains.Implementation
{
    public class UserTypeDomain : IUserTypeDomain
    {
        IBaseRepositoryInterface<UserTypeEntity> repository;
        private readonly ILogger<UserTypeEntity> logger;
        public UserTypeDomain(IBaseRepositoryInterface<UserTypeEntity> _repository, ILogger<UserTypeEntity> _logger)
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
            var item = await FindByID(entity.ID);
            if (item.Status == 0)
            {
                item.Entity.IsVisable = !item.Entity.IsVisable;
                result = await Update(item.Entity);
            }
            else
            {
                result.Status = 2;
                result.MessageEnglish = CommonDomainMessages.Err_MessageTemplateNotFoundEn;
            }
            return result;
        }

        public async Task<ResultEntity<UserTypeEntity>> EnableDisableItem(UserTypeEntity entity)
        {
            ResultEntity<UserTypeEntity> result = new ResultEntity<UserTypeEntity>();
            var item = await FindByID(entity.ID);
            if (item.Status == 0)
            {
                item.Entity.IsEnabled = !item.Entity.IsEnabled;
                result = await Update(item.Entity);
            }
            else
            {
                result.Status = 2;
                result.MessageEnglish = CommonDomainMessages.Err_MessageTemplateNotFoundEn;
            }
            return result;
        }

        public async Task<ResultList<UserTypeEntity>> FindAllItems()
        {
            return await repository.FindAllItems();
        }

        public async Task<ResultList<UserTypeEntity>> FindAllActiveAndVisableItems()
        {
            return await repository.FindByQuery(a => a.IsEnabled == true && a.IsVisable == true);
        }


        public async Task<ResultEntity<UserTypeEntity>> FindByCode(string code)
        {
            return await repository.FindOneByQuery(a => a.Code == code);
        }

        public async Task<ResultEntity<UserTypeEntity>> FindByID(Guid id)
        {
            return await repository.FindOneByQuery(a => a.ID == id);
        }


    }
}
