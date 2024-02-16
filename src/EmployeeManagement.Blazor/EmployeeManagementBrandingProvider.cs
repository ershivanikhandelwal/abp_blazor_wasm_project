using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EmployeeManagement.Blazor;

[Dependency(ReplaceServices = true)]
public class EmployeeManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EmployeeManagement";
}
