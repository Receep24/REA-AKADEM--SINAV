using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class BankAccount : Entity<int>
    {
       
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public IList<Transaction> Transactions { get; set; }
    }
}
