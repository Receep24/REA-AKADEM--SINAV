using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }

    ITransactionRepository Transaction { get; }
    IBankAccountRepository BankAccount { get; }

    Task<int> CommitAsync();
}