using org.newproject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace org.newproject.Permissions;

public class newprojectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(newprojectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(newprojectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<newprojectResource>(name);
    }
}
