using EmployeeManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EmployeeManagementController : AbpControllerBase
{
    protected EmployeeManagementController()
    {
        LocalizationResource = typeof(EmployeeManagementResource);
    }
}
