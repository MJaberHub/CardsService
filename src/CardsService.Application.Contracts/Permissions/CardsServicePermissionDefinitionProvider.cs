using CardsService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CardsService.Permissions;

public class CardsServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CardsServicePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CardsServicePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CardsServiceResource>(name);
    }
}
