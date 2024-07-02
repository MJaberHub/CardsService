using System;
using System.Collections.Generic;
using System.Text;
using CardsService.Localization;
using Volo.Abp.Application.Services;

namespace CardsService;

/* Inherit your application services from this class.
 */
public abstract class CardsServiceAppService : ApplicationService
{
    protected CardsServiceAppService()
    {
        LocalizationResource = typeof(CardsServiceResource);
    }
}
