using NetCoreHRProject.Entity.Common.Entities;
using NetCoreHRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreHRProject.DataAccess.Interfaces
{
    public interface IUserTypeRepository
    {
        Task<ResultEntity<UserTypeEntity>> Insert(UserTypeEntity entity);
        Task<ResultEntity<UserTypeEntity>> Update(UserTypeEntity entity);
        Task<ResultEntity<UserTypeEntity>> Delete(UserTypeEntity entity);
        Task<ResultEntity<UserTypeEntity>> HideShowItem(UserTypeEntity entity);
        Task<ResultList<UserTypeEntity>> FindAllItems();
        Task<ResultEntity<UserTypeEntity>> FindByCode(string code);
        Task<ResultEntity<UserTypeEntity>> FindByID(Guid id);
        Task<ResultEntity<UserTypeEntity>> EnableDisableItem(UserTypeEntity entity);
        Task<ResultList<UserTypeEntity>> FindAllActiveAndVisableItems();
        Task<ResultEntity<int>> GetCount();
    }
}
