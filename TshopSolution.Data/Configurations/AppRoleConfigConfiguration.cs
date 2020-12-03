using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TshopSolution.Data.Entites;

namespace TshopSolution.Data.Configurations
{
   public class AppRoleConfigConfiguration:IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRole");

            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
        }
    }
}
