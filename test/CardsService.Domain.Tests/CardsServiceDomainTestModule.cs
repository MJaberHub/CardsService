using Volo.Abp.Modularity;

namespace CardsService;

[DependsOn(
    typeof(CardsServiceDomainModule),
    typeof(CardsServiceTestBaseModule)
)]
public class CardsServiceDomainTestModule : AbpModule
{

}
