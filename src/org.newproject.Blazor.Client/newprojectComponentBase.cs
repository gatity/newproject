using org.newproject.Localization;
using Volo.Abp.AspNetCore.Components;

namespace org.newproject.Blazor.Client;

public abstract class newprojectComponentBase : AbpComponentBase
{
    protected newprojectComponentBase()
    {
        LocalizationResource = typeof(newprojectResource);
    }
}
