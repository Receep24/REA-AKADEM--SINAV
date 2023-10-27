using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public int Age { get; set; } = default!;
    public string? UserImage { get; set; }
    public string PhoneNumber { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public UserType UserType { get; set; } = UserType.User;
    public Gender Gender { get; set; }

    public IList<BankAccount> BankAccounts { get; set; }
}

public enum UserType
{
    Admin,
    User,
    Employee,
}
public enum Gender
{
    Male,
    Female,
}
