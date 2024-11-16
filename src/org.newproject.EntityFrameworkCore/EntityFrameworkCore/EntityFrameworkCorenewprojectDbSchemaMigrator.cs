using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using org.newproject.Data;
using Volo.Abp.DependencyInjection;

namespace org.newproject.EntityFrameworkCore;

public class EntityFrameworkCorenewprojectDbSchemaMigrator
    : InewprojectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorenewprojectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the newprojectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<newprojectDbContext>()
            .Database
            .MigrateAsync();
    }
}
