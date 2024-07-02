using Volo.Abp.Modularity;

namespace CardsService;

/* Inherit from this class for your domain layer tests. */
public abstract class CardsServiceDomainTestBase<TStartupModule> : CardsServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
