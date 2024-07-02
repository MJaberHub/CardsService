using Localization.Resources.AbpUi;
using CardsService.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;

namespace CardsService;

[DependsOn(
    typeof(CardsServiceApplicationContractsModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
public class CardsServiceHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<CardsServiceResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
