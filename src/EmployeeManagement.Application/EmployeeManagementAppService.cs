using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Localization;
using Volo.Abp.Application.Services;

namespace EmployeeManagement;

/* Inherit your application services from this class.
 */
public abstract class EmployeeManagementAppService : ApplicationService
{
    protected EmployeeManagementAppService()
    {
        LocalizationResource = typeof(EmployeeManagementResource);
    }
}
