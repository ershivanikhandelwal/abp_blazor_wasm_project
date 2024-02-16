using Volo.Abp.Modularity;

namespace EmployeeManagement;

public abstract class EmployeeManagementApplicationTestBase<TStartupModule> : EmployeeManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
