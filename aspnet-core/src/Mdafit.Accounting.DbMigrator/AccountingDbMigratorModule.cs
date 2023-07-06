using Mdafit.Accounting.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Mdafit.Accounting.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AccountingEntityFrameworkCoreModule),
    typeof(AccountingApplicationContractsModule)
    )]
public class AccountingDbMigratorModule : AbpModule
{

}
