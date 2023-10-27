using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class TransactionRepository : Repository<Transaction, int>, ITransactionRepository
    {
        public TransactionRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Transaction>> GetAllAsync(Expression<Func<Transaction, bool>>? filter = null)
        {
            IQueryable<Transaction> advertQuery = PostgresContext.Set<Transaction>();

            if (filter != null)
            {
                advertQuery = advertQuery.Where(filter);
            }

            var transactions = await advertQuery
                .Include(r => r.BankAccount)
                
                .ToListAsync();

            return transactions;
        }
        public Task<IList<Transaction>> GetByAdvertIdAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}
