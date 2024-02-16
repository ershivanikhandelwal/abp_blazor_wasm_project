using EmployeeManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EmployeeManagement.Permissions;

public class EmployeeManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EmployeeManagementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EmployeeManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EmployeeManagementResource>(name);
    }
}
