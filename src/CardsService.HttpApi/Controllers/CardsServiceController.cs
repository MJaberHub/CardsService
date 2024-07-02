using CardsService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CardsService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CardsServiceController : AbpControllerBase
{
    protected CardsServiceController()
    {
        LocalizationResource = typeof(CardsServiceResource);
    }
}
