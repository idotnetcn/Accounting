using Mdafit.Accounting.Accounts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
            b.Property(x => x.Balance).IsRequired().HasDefaultValue(0).HasComment("账户余额");
            b.Property(x => x.Currency).IsRequired().HasComment("币别代码,国际标准");
            b.Property(x => x.Name).IsRequired().HasComment("账户名称");
            b.Property(x => x.ParentId).IsRequired(false).HasComment("上级账户ID");
            b.Property(x => x.Remark).IsRequired(false).HasComment("备注");
            b.Property(x => x.Type).HasMaxLength(100).HasComment("账户分类");
            b.Property(x => x.Icon).IsRequired(false).HasComment("图标");
            b.Property(x => x.Id).HasComment("主键ID");
            b.Property(x => x.ConcurrencyStamp).HasComment("并发戳");
            b.Property(x => x.CreationTime).HasComment("创建时间");
            b.Property(x => x.CreatorId).HasComment("创建人ID");
            b.Property(x => x.DeleterId).HasComment("删除人ID");
            b.Property(x => x.DeletionTime).HasComment("删除时间");
            b.Property(x => x.ExtraProperties).IsRequired().HasDefaultValue("{}").HasComment("拓展信息对象");
            b.Property(x => x.IsDeleted).HasComment("是否已删除,true=已删除");
            b.Property(x => x.LastModificationTime).HasComment("最后修改时间");
            b.Property(x => x.LastModifierId).HasComment("最后修改人ID");
            b.Property(x => x.TenantId).HasComment("租户ID");
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
