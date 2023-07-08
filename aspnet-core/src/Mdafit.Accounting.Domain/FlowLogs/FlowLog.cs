
namespace Mdafit.Accounting.FlowLogs;

public class FlowLog : EntityFullRoot
{
    /// <summary>
    /// 分类ID
    /// </summary>
    public virtual Guid? CategoryId { get; protected set; }
    /// <summary>
    /// 账户ID
    /// </summary>
    public virtual Guid? AccountId { get; protected set; }
    /// <summary>
    /// 成员ID
    /// </summary>
    public virtual Guid? MemberId { get; protected set; }
    /// <summary>
    /// 商家ID
    /// </summary>
    public virtual Guid? StoreId { get; protected set; }
    /// <summary>
    /// 项目ID
    /// </summary>
    public virtual Guid? ProjectId { get; protected set; }
    /// <summary>
    /// 流水类型
    /// </summary>
    public virtual string Type { get; protected set; } = string.Empty;
    /// <summary>
    /// 币别代码
    /// </summary>
    public virtual string Currency { get; protected set; } = string.Empty;
    /// <summary>
    /// 实付金额
    /// </summary>
    public virtual decimal Amount { get; protected set; } = 0;
    /// <summary>
    /// 优惠金额
    /// </summary>
    public virtual decimal DiscountAmount { get; protected set; } = 0;
    /// <summary>
    /// 交易时间
    /// </summary>
    public virtual DateTime TradeTime { get; protected set; } = DateTime.Now;
}
