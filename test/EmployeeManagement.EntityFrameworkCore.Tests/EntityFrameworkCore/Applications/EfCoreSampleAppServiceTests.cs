using EmployeeManagement.Samples;
using Xunit;

namespace EmployeeManagement.EntityFrameworkCore.Applications;

[Collection(EmployeeManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<EmployeeManagementEntityFrameworkCoreTestModule>
{

}
