using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        //CREATE 
        CreateMap<RegisterDto, User>();
        CreateMap<CreateTransactionDto, Transaction>();
        CreateMap<CreateBankAccountDto, BankAccount>();

        //UPDATE
        CreateMap<TransactionUpdateDTO, Transaction>();
        CreateMap<BankAccountUpdateDTO, BankAccount>();
        CreateMap<UserProfileUpdateDto, User>();

        //RESPONSE
        CreateMap<User, UserProfileDto>();
        CreateMap<Transaction, TransactionInfoDto>();
        CreateMap<BankAccount, BankAccountInfoDto>();
    }
}