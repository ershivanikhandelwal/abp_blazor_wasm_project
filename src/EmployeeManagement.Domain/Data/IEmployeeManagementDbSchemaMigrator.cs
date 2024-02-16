using System.Threading.Tasks;

namespace EmployeeManagement.Data;

public interface IEmployeeManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
