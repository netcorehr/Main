

using Microsoft.EntityFrameworkCore;
using NetCoreHRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreHRProject.DataAccess.Common
{
    public class MainApplicationDBContext : DbContext
    {
        public MainApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<UserTypeEntity> UserTypeDBSet { set; get; }
     
    }
}
