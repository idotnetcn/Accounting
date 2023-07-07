
namespace Mdafit.Accounting.Enums;
/// <summary>
/// 账户分类
/// </summary>
public enum AccountCategoryEnum
{
    /// <summary>
    /// 现金
    /// </summary>
    [Description("")]
    cash = 0,
    /// <summary>
    /// 信用卡
    /// </summary>
    credit = 1,
    /// <summary>
    /// 储蓄卡
    /// </summary>
    debit = 2,
    /// <summary>
    /// 虚拟账户
    /// </summary>
    @virtual = 3,
    /// <summary>
    /// 股票
    /// </summary>
    stock = 4,
    /// <summary>
    /// 基金
    /// </summary>
    fund = 5,
    /// <summary>
    /// 负债账户
    /// </summary>
    liability = 6,
    /// <summary>
    /// 债权账户
    /// </summary>
    debt_claim = 7
}
