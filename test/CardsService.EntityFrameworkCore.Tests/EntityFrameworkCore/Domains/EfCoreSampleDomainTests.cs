using CardsService.Samples;
using Xunit;

namespace CardsService.EntityFrameworkCore.Domains;

[Collection(CardsServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CardsServiceEntityFrameworkCoreTestModule>
{

}
