using Microsoft.Extensions.DependencyInjection;
using NetCoreHRProject.DataAccess.Base;
using NetCoreHRProject.DataAccess.Interfaces;
using NetCoreHRProject.DataAccess.Repository;
using NetCoreHRProject.Domain.Implementation;
using NetCoreHRProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreHRProject.DI
{
   public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepositoryInterface<>), typeof(BaseRepository<>));



            services.AddScoped<IUserTypeRepository, UserTypeRepository>();



            services.AddScoped<IUserTypeDomain, UserTypeDomain>();
   
        }
    }
}
