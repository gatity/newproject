using org.newproject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace org.newproject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class newprojectController : AbpControllerBase
{
    protected newprojectController()
    {
        LocalizationResource = typeof(newprojectResource);
    }
}
