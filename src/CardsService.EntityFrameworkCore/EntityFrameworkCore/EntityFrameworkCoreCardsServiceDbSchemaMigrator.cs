using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CardsService.Data;
using Volo.Abp.DependencyInjection;

namespace CardsService.EntityFrameworkCore;

public class EntityFrameworkCoreCardsServiceDbSchemaMigrator
    : ICardsServiceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCardsServiceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CardsServiceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CardsServiceDbContext>()
            .Database
            .MigrateAsync();
    }
}
