using Volo.Abp.Modularity;

namespace EmployeeManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class EmployeeManagementDomainTestBase<TStartupModule> : EmployeeManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
