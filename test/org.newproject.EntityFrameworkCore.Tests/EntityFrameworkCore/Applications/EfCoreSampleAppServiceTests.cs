using org.newproject.Samples;
using Xunit;

namespace org.newproject.EntityFrameworkCore.Applications;

[Collection(newprojectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<newprojectEntityFrameworkCoreTestModule>
{

}
