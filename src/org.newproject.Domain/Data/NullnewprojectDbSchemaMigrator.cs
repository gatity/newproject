using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace org.newproject.Data;

/* This is used if database provider does't define
 * InewprojectDbSchemaMigrator implementation.
 */
public class NullnewprojectDbSchemaMigrator : InewprojectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
