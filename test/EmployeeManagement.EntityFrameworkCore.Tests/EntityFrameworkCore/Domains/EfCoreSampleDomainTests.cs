using EmployeeManagement.Samples;
using Xunit;

namespace EmployeeManagement.EntityFrameworkCore.Domains;

[Collection(EmployeeManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<EmployeeManagementEntityFrameworkCoreTestModule>
{

}
