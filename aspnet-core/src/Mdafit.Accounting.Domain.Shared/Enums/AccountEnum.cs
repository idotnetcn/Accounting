
namespace Mdafit.Accounting.Enums;
/// <summary>
/// 账户分类
/// </summary>
public enum AccountTypeEnum
{
    /// <summary>
    /// 资金账户
    /// </summary>
    /// <remarks>
    /// 如借记卡，现金
    /// </remarks>
    fund = 1,
    /// <summary>
    /// 信用卡
    /// </summary>
    credit = 2,
    /// <summary>
    /// 虚拟账户/充值卡账户
    /// </summary>
    @virtual = 3,
    /// <summary>
    /// 投资理财
    /// </summary>
    investment = 4,
    /// <summary>
    /// 债务
    /// </summary>
    /// <remarks>
    /// 借入/借出
    /// </remarks>
    debt = 5
}
