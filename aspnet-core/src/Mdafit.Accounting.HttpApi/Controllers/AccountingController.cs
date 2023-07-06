using Mdafit.Accounting.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mdafit.Accounting.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AccountingController : AbpControllerBase
{
    protected AccountingController()
    {
        LocalizationResource = typeof(AccountingResource);
    }
}
