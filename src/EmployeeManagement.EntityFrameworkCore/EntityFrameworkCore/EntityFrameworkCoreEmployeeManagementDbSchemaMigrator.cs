using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmployeeManagement.Data;
using Volo.Abp.DependencyInjection;

namespace EmployeeManagement.EntityFrameworkCore;

public class EntityFrameworkCoreEmployeeManagementDbSchemaMigrator
    : IEmployeeManagementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEmployeeManagementDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the EmployeeManagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EmployeeManagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
