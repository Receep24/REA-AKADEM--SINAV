using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Request.Functional;
using Business.Models.Response;
using Business.Services;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using System.Transactions;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class BankAccountController : BaseCRUDController<BankAccount, int, CreateBankAccountDto, BankAccountUpdateDTO, BankAccountInfoDto>
    {
        IBankAccountService bankAccountService;
        public BankAccountController(IBankAccountService service) : base(service)
        {
            bankAccountService = service;
            
        }
    }
}
