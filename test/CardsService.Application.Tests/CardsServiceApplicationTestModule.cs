using Volo.Abp.Modularity;

namespace CardsService;

[DependsOn(
    typeof(CardsServiceApplicationModule),
    typeof(CardsServiceDomainTestModule)
)]
public class CardsServiceApplicationTestModule : AbpModule
{

}
