using Volo.Abp.Settings;

namespace org.newproject.Settings;

public class newprojectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(newprojectSettings.MySetting1));
    }
}
