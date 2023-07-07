using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Mdafit.Accounting.EntityFrameworkCore;

[DependsOn(
    typeof(AccountingDomainModule),
    typeof(AbpIdentityEntityFrameworkCoreModule),
    typeof(AbpOpenIddictEntityFrameworkCoreModule),
    typeof(AbpPermissionManagementEntityFrameworkCoreModule),
    typeof(AbpSettingManagementEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCorePostgreSqlModule),
    typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
    typeof(AbpAuditLoggingEntityFrameworkCoreModule),
    typeof(AbpTenantManagementEntityFrameworkCoreModule),
    typeof(AbpFeatureManagementEntityFrameworkCoreModule)
    )]
public class AccountingEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        // https://www.npgsql.org/efcore/release-notes/6.0.html#opting-out-of-the-new-timestamp-mapping-logic
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        AccountingEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<AccountingDbContext>(options =>
        {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
        });
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.Databases.Configure("", db =>
            {
                //db.MappedConnections.Add("AbpIdentity");
                //db.MappedConnections.Add("AbpTenantManagement");
                db.MappedConnections.Add("AbpOpenIddict");
                db.MappedConnections.Add("AbpAuditLogging");
                db.MappedConnections.Add("AbpBackgroundJobs");
                db.MappedConnections.Add("AbpFeatureManagement");
                db.MappedConnections.Add("AbpSettingManagement");
                db.MappedConnections.Add("AbpPermissionManagement");
            });
        });
        Configure<AbpDbContextOptions>(options =>
        {
                /* The main point to change your DBMS.
                 * See also AccountingMigrationsDbContextFactory for EF Core tooling. */
            options.UseNpgsql();
        });
        Configure<AbpEntityOptions>(options =>
        {//配置Include关联查询,子查询,此处配置后就不用在Repository等其他地方配置
            options.ConfigureEntityOptions();
        });
    }
}
