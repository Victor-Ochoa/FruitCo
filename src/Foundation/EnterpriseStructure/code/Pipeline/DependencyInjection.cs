using FruitCo.Foundation.EnterpriseStructure.Interface;
using FruitCo.Foundation.EnterpriseStructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCo.Foundation.EnterpriseStructure.Pipeline
{
  public class DependencyInjection : IServicesConfigurator
  {
    public void Configure(IServiceCollection serviceCollection)
    {
      serviceCollection.AddTransient<IEnterprise, Enterprise>();
      serviceCollection.AddTransient<ISite, Site>();
    }
  }
}
