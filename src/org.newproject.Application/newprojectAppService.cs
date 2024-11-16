using System;
using System.Collections.Generic;
using System.Text;
using org.newproject.Localization;
using Volo.Abp.Application.Services;

namespace org.newproject;

/* Inherit your application services from this class.
 */
public abstract class newprojectAppService : ApplicationService
{
    protected newprojectAppService()
    {
        LocalizationResource = typeof(newprojectResource);
    }
}
