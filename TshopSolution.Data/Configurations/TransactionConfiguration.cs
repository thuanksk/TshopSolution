using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using TshopSolution.Data.Entites;


namespace TshopSolution.Data.Configurations
{
  public class TransactionConfiguration : IEntityTypeConfiguration<TranSaction>
    {
        public void Configure(EntityTypeBuilder<TranSaction> builder)
        {
            builder.ToTable("TranSactions");

            builder.HasKey(x=> x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
