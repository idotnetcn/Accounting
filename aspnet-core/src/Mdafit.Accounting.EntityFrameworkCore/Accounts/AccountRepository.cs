
namespace Mdafit.Accounting.Accounts;

public class AccountRepository : EfCoreRepository<AccountingDbContext, Account, Guid>, IAccountRepository
{
    public AccountRepository(IDbContextProvider<AccountingDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
