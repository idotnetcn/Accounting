
namespace Mdafit.Accounting.Projects;

public class Project : EntityFullRoot
{
    /// <summary>
    /// 项目名称
    /// </summary>
    public virtual string Name { get; protected set; } = string.Empty;
    /// <summary>
    /// 图标
    /// </summary>
    public virtual string? Icon { get; protected set; }
}
