﻿
using Cockles.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace Cockles.Mapping.SystemManage
{
    public class ItemsDetailMap : EntityTypeConfiguration<ItemsDetailEntity>
    {
        public ItemsDetailMap()
        {
            this.ToTable("Sys_ItemsDetail");
            this.HasKey(t => t.F_Id);
        }
    }
}
