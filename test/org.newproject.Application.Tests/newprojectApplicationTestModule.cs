using Volo.Abp.Modularity;

namespace org.newproject;

[DependsOn(
    typeof(newprojectApplicationModule),
    typeof(newprojectDomainTestModule)
)]
public class newprojectApplicationTestModule : AbpModule
{

}
