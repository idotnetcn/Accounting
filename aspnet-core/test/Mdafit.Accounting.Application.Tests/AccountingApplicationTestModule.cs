using Volo.Abp.Modularity;

namespace Mdafit.Accounting;

[DependsOn(
    typeof(AccountingApplicationModule),
    typeof(AccountingDomainTestModule)
    )]
public class AccountingApplicationTestModule : AbpModule
{

}
