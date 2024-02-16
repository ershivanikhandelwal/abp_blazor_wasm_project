using EmployeeManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace EmployeeManagement.Blazor;

public abstract class EmployeeManagementComponentBase : AbpComponentBase
{
    protected EmployeeManagementComponentBase()
    {
        LocalizationResource = typeof(EmployeeManagementResource);
    }
}
