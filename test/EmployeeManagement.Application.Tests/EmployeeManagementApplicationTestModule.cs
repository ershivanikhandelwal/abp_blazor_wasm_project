using Volo.Abp.Modularity;

namespace EmployeeManagement;

[DependsOn(
    typeof(EmployeeManagementApplicationModule),
    typeof(EmployeeManagementDomainTestModule)
)]
public class EmployeeManagementApplicationTestModule : AbpModule
{

}
