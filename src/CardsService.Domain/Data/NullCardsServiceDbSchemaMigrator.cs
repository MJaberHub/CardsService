using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CardsService.Data;

/* This is used if database provider does't define
 * ICardsServiceDbSchemaMigrator implementation.
 */
public class NullCardsServiceDbSchemaMigrator : ICardsServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
