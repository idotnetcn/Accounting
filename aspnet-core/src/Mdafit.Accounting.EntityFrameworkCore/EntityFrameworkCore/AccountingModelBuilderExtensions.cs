using Mdafit.Accounting.Accounts;

namespace Mdafit.Accounting.EntityFrameworkCore;

public static class AccountingModelBuilderExtensions
{
    public static void ConfigureAccounting(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(b =>
        {
            b.ToTable(AccountingDbProperties.DbTablePrefix + nameof(Accounts), AccountingDbProperties.DbSchema);
            b.ToTable(x => x.HasComment("账户信息"));
            b.ConfigureByConvention();
            b.Property(x => x.Balance).IsRequired().HasComment("账户余额");
            b.Property(x => x.Category).HasMaxLength(100).HasComment("账户分类");
        });

    }

    public static void ConfigureEntityOptions(this AbpEntityOptions entityOptions)
    {
        //entityOptions.Entity<DataDictionary>(entityOptions =>
        //{
        //    entityOptions.DefaultWithDetailsFunc = query => query.Include(o => o.Items);//.Include(o => o.Childrens)
        //});
    }
}
