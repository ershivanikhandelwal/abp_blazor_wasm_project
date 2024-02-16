using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EmployeeManagement.Data;

/* This is used if database provider does't define
 * IEmployeeManagementDbSchemaMigrator implementation.
 */
public class NullEmployeeManagementDbSchemaMigrator : IEmployeeManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
