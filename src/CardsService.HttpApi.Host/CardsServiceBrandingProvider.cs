using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CardsService;

[Dependency(ReplaceServices = true)]
public class CardsServiceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CardsService";
}
