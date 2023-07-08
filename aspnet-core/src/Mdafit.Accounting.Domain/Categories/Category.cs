
namespace Mdafit.Accounting.Categories;

public class Category : EntityFullRoot
{
    /// <summary>
    /// 上级ID
    /// </summary>
    public virtual Guid? ParentId { get; protected set; }
    /// <summary>
    /// 分类名称
    /// </summary>
    public virtual string Name { get; protected set; } = string.Empty;
    /// <summary>
    /// 编码
    /// </summary>
    /// <remarks>
    /// 包含层级关系的编码结构,层级之间用.连接
    /// </remarks>
    public virtual string Code { get; protected set; } = string.Empty;
    /// <summary>
    /// 分类类别
    /// </summary>
    /// <remarks>
    /// 如：incom收入分类/expend支出分类
    /// </remarks>
    public virtual string Type { get; protected set; } = string.Empty;
    /// <summary>
    /// 图标
    /// </summary>
    public virtual string? Icon { get; protected set; }
}
