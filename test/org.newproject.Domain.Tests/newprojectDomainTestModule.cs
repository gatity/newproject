using Volo.Abp.Modularity;

namespace org.newproject;

[DependsOn(
    typeof(newprojectDomainModule),
    typeof(newprojectTestBaseModule)
)]
public class newprojectDomainTestModule : AbpModule
{

}
