using org.newproject.Samples;
using Xunit;

namespace org.newproject.EntityFrameworkCore.Domains;

[Collection(newprojectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<newprojectEntityFrameworkCoreTestModule>
{

}
