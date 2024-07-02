using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.SettingManagement;

namespace CardsService;

[DependsOn(
    typeof(CardsServiceDomainSharedModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule)
)]
public class CardsServiceApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        CardsServiceDtoExtensions.Configure();
    }
}
