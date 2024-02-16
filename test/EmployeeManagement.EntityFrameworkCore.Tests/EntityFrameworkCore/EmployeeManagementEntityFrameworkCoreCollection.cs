using Xunit;

namespace EmployeeManagement.EntityFrameworkCore;

[CollectionDefinition(EmployeeManagementTestConsts.CollectionDefinitionName)]
public class EmployeeManagementEntityFrameworkCoreCollection : ICollectionFixture<EmployeeManagementEntityFrameworkCoreFixture>
{

}
