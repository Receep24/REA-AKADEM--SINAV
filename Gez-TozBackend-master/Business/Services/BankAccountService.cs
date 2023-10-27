using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class BankAccountService : BaseService<BankAccount, BankAccountInfoDto, int>, IBankAccountService
    {
        public BankAccountService(IMapperHelper mapperHelper, UnitOfWork unitOfWork) : base(mapperHelper, unitOfWork.BankAccount, unitOfWork)
        {
        }
    }
}
