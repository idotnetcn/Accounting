
namespace Mdafit.Accounting.Members;

public class Member : EntityFullRoot
{
    /// <summary>
    /// 成员名称
    /// </summary>
    public virtual string Name { get; protected set; } = string.Empty;
    /// <summary>
    /// 图标
    /// </summary>
    public virtual string? Icon { get; protected set; }
}
