using Volo.Abp.Modularity;

namespace EmployeeManagement;

[DependsOn(
    typeof(EmployeeManagementDomainModule),
    typeof(EmployeeManagementTestBaseModule)
)]
public class EmployeeManagementDomainTestModule : AbpModule
{

}
