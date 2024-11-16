using Volo.Abp.Modularity;

namespace org.newproject;

/* Inherit from this class for your domain layer tests. */
public abstract class newprojectDomainTestBase<TStartupModule> : newprojectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
