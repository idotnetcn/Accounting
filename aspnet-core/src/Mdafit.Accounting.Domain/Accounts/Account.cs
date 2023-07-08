

namespace Mdafit.Accounting.Accounts;

/// <summary>
/// 账户信息
/// </summary>
public class Account : EntityFullRoot
{
    /// <summary>
    /// 上级账户ID
    /// </summary>
    public virtual Guid? ParentId { get; protected set; }
    /// <summary>
    /// 编码
    /// </summary>
    /// <remarks>
    /// 包含层级关系的编码结构,层级之间用.连接
    /// </remarks>
    public virtual string Code { get; protected set; } = string.Empty;
    /// <summary>
    /// 账户名称
    /// </summary>
    public virtual string Name { get; protected set; } = string.Empty;
    /// <summary>
    /// 账户分类    
    /// </summary>
    /// <remarks>
    /// 详见系统枚举，如cash=现金
    /// </remarks>
    public virtual string Type { get; protected set; } = string.Empty;
    /// <summary>
    /// 账户图标
    /// </summary>
    public virtual string? Icon { get; protected set; }
    /// <summary>
    /// 币别
    /// </summary>
    /// <remarks>
    /// 国际通用标准代码
    /// </remarks>
    public virtual string Currency { get; protected set; } = string.Empty;
    /// <summary>
    /// 备注
    /// </summary>
    public virtual string? Remark { get; protected set; }
    /// <summary>
    /// 账户余额
    /// </summary>
    public virtual decimal Balance { get; protected set; } = 0;
    /// <summary>
    /// 计入资产
    /// </summary>
    /// <remarks>默认true，计入资产</remarks>
    public virtual bool InAssets { get; protected set; } = true;

    public Account()
    {

    }

    public Account(Guid? parentId, string code, string name, string category, string? icon, string currency, string? remark, decimal balance, bool inAssets) : this()
    {
        ParentId = parentId;
        Code = code;
        Name = name;
        Type = category;
        Icon = icon;
        Currency = currency;
        Remark = remark;
        Balance = balance;
        InAssets = inAssets;
    }
}
