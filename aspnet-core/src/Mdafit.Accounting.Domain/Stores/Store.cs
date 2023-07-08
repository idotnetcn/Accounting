
namespace Mdafit.Accounting.Stores;

public class Store : EntityFullRoot
{
    /// <summary>
    /// 商家名称
    /// </summary>
    public virtual string Name { get; protected set; } = string.Empty;
    /// <summary>
    /// 图标
    /// </summary>
    public virtual string? Icon { get; protected set; }
}
