using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCo.Foundation.EnterpriseStructure.Interface
{
  public interface IEnterprise
  {
    Item GetEnterpriseFromCurrentSite();
  }
}
