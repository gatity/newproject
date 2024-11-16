using Microsoft.Extensions.Localization;
using org.newproject.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace org.newproject.Blazor;

[Dependency(ReplaceServices = true)]
public class newprojectBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<newprojectResource> _localizer;

    public newprojectBrandingProvider(IStringLocalizer<newprojectResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
