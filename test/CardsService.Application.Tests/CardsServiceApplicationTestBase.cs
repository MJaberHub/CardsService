using Volo.Abp.Modularity;

namespace CardsService;

public abstract class CardsServiceApplicationTestBase<TStartupModule> : CardsServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
