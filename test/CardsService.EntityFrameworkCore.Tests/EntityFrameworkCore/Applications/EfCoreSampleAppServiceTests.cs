using CardsService.Samples;
using Xunit;

namespace CardsService.EntityFrameworkCore.Applications;

[Collection(CardsServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CardsServiceEntityFrameworkCoreTestModule>
{

}
