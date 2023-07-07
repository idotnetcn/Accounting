namespace Mdafit.Accounting;
/// <summary>
/// 实体完整基类
/// </summary>
/// <remarks>
/// 继承于Volo.Abp.Domain.Entities.Auditing.FullAuditedAggregateRoot，主键Guid类型，包括TenantId
/// </remarks>
public class EntityFullRoot: FullAuditedAggregateRoot<Guid>, IMultiTenant
{
    /// <summary>
    /// 租户ID
    /// </summary>
    public virtual Guid? TenantId { get; protected set; }
}
