using FruitCo.Foundation.DI.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace FruitCo.Foundation.DI.Pipeline
{
  public class RegisterControllers : IServicesConfigurator
  {
    public void Configure(IServiceCollection serviceCollection)
    {
      serviceCollection.AddMvcControllers(
          "FruitCo.Feature.*");
    }
  }
}
