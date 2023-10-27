using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class TransactionConfiguration : BaseConfiguration<Transaction,int>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            base.Configure(builder);
            builder.Property(u => u.TransactionDate).IsRequired();
            builder.Property(u => u.Description).IsRequired();
            builder.Property(u => u.Amount).IsRequired();
            builder.Property(u => u.AccountID).IsRequired();

            builder.HasOne(t => t.BankAccount)
           .WithMany(a => a.Transactions)
           .HasForeignKey(t => t.AccountID)
           .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
