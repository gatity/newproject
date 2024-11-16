using Volo.Abp.Modularity;

namespace org.newproject;

public abstract class newprojectApplicationTestBase<TStartupModule> : newprojectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
