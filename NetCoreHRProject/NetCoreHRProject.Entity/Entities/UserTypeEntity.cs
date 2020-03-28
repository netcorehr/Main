using NetCoreHRProject.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreHRProject.Entity.Entities
{
    [Table("User_Types")]
    public class UserTypeEntity : BaseLookupEntity
    {
    }
}
