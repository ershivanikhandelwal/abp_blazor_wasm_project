using Volo.Abp.Settings;

namespace EmployeeManagement.Settings;

public class EmployeeManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EmployeeManagementSettings.MySetting1));
    }
}
