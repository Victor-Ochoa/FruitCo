using FruitCo.Foundation.Core.Extensions;
using FruitCo.Foundation.EnterpriseStructure.Interface;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCo.Foundation.EnterpriseStructure.Services
{
  public class Enterprise : IEnterprise
  {
    public Item GetEnterpriseFromCurrentSite(Item currentItem)
    {
      var site = currentItem.GetFirstItemsParentByTemplateId(Templates.SiteRoot.TemplateId);
      var enterpriceId = site.Fields[Templates.SiteRoot.Fields.Entreprise].GetValue(true);
      return Sitecore.Context.Database.GetItem(new Sitecore.Data.ID(enterpriceId));
    }
  }
}
