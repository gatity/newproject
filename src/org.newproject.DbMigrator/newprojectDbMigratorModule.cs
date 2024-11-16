using org.newproject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace org.newproject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(newprojectEntityFrameworkCoreModule),
    typeof(newprojectApplicationContractsModule)
    )]
public class newprojectDbMigratorModule : AbpModule
{
}
