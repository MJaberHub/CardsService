using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;

namespace CardsService;

[DependsOn(
    typeof(CardsServiceDomainModule),
    typeof(CardsServiceApplicationContractsModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class CardsServiceApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<CardsServiceApplicationModule>();
        });
    }
}
