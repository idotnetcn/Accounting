using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Mdafit.Accounting;

[Dependency(ReplaceServices = true)]
public class AccountingBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Accounting";
}
