using Xunit;

namespace CardsService.EntityFrameworkCore;

[CollectionDefinition(CardsServiceTestConsts.CollectionDefinitionName)]
public class CardsServiceEntityFrameworkCoreCollection : ICollectionFixture<CardsServiceEntityFrameworkCoreFixture>
{

}
