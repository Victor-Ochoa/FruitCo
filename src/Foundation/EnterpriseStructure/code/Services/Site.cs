using FruitCo.Foundation.EnterpriseStructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCo.Foundation.EnterpriseStructure.Services
{
  public class Site : ISite
  {
    public string GetStartUrl()
    {
      var startItem = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.ContentStartPath);
      return Sitecore.Links.LinkManager.GetItemUrl(startItem, new Sitecore.Links.UrlBuilders.ItemUrlBuilderOptions() { LanguageEmbedding = Sitecore.Links.LanguageEmbedding.Never });
    }
  }
}
