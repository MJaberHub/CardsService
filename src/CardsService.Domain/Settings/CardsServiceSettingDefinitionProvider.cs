using Volo.Abp.Settings;

namespace CardsService.Settings;

public class CardsServiceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CardsServiceSettings.MySetting1));
    }
}
