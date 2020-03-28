﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreHRProject.Entity.Base
{
    [Serializable]
    public abstract class BaseLookupEntity
    {
        [Column("ID", Order = 0)]
        [Key]
        public Guid ID { set; get; } = Guid.NewGuid();
        [Column("Code", Order = 1)]
        public string Code { set; get; }
        [Column("Name", Order = 3)]
        public string Name { set; get; }
        [Column("Is_Enabled", Order = 4)]
        public bool IsEnabled { set; get; } = true;
        [Column("Is_Visable", Order = 5)]
        public bool IsVisable { set; get; } = true;
        [Column("Created_By")]
        public Guid? CreatedBy { set; get; }
        [Column("Updated_By")]
        public Guid? UpdatedBy { set; get; }
        [Column("Created_On")]
        public DateTime? CreatedOn { set; get; } = DateTime.Now;
        [Column("Updated_On")]
        public DateTime? UpdatedOn { set; get; }
    }
}