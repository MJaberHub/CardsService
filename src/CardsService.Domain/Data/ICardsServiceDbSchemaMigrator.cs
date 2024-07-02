using System.Threading.Tasks;

namespace CardsService.Data;

public interface ICardsServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
