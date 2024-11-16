using System.Threading.Tasks;

namespace org.newproject.Data;

public interface InewprojectDbSchemaMigrator
{
    Task MigrateAsync();
}
