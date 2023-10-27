using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class BankAccountConfiguration : BaseConfiguration<BankAccount, int>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            base.Configure(builder);
            builder.Property(u => u.AccountNumber).IsRequired();
            builder.Property(u => u.Balance).IsRequired();
            builder.Property(u => u.UserID).IsRequired();


            builder.HasOne(t => t.User)
          .WithMany(a => a.BankAccounts)
          .HasForeignKey(t => t.UserID)
          .OnDelete(DeleteBehavior.Cascade);





        }
    }
}
