using Mdafit.Accounting.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Mdafit.Accounting;

[DependsOn(
    typeof(AccountingEntityFrameworkCoreTestModule)
    )]
public class AccountingDomainTestModule : AbpModule
{

}
