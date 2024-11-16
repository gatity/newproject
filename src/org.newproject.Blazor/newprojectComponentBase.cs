using org.newproject.Localization;
using Volo.Abp.AspNetCore.Components;

namespace org.newproject.Blazor;

public abstract class newprojectComponentBase : AbpComponentBase
{
    protected newprojectComponentBase()
    {
        LocalizationResource = typeof(newprojectResource);
    }
}
