using EmployeeManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace EmployeeManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EmployeeManagementEntityFrameworkCoreModule),
    typeof(EmployeeManagementApplicationContractsModule)
    )]
public class EmployeeManagementDbMigratorModule : AbpModule
{
}
