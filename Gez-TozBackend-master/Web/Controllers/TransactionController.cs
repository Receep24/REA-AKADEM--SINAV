using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using System.Transactions;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class TransactionController : BaseCRUDController<Transaction, int, CreateTransactionDto, TransactionUpdateDTO, TransactionInfoDto>
    {
        ITransactionService _service;
        public TransactionController(ITransactionService service) : base(service)
        {
            _service = service;
        }
    }
}
