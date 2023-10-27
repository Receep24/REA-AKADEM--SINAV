using Business.Models.Response;
using Business.Services.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business.Services.Interface
{
    public interface ITransactionService : IBaseService<Transaction, TransactionInfoDto, int>
    {
    }
}
