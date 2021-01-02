using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCo.Foundation.Core.Extensions
{
  public static class ItemExtension
  {


    public static Item[] GetAllItemsAncestorsByTemplateId(this Item item, ID template)
    {
      var returnList = new List<Item>();

      if (item.TemplateID == template)
        returnList.Add(item);

      if (item.HasChildren)
        foreach (var itemChildren in item.Children.ToArray())
        {
          returnList.AddRange(itemChildren.GetAllItemsAncestorsByTemplateId(template));
        }

      return returnList.ToArray();
    }
    public static Item GetFirstItemsAncestorByTemplateId(this Item item, ID template)
    {
      if (item.TemplateID == template)
        return item;

      if (item.HasChildren)
        foreach (var itemChildren in item.Children.ToArray())
        {
          return itemChildren.GetFirstItemsAncestorByTemplateId(template);
        }

      return null;
    }
    public static Item GetFirstItemsParentByTemplateId(this Item item, ID template)
    {
      if (item.TemplateID == template)
        return item;

      return item.Parent.GetFirstItemsParentByTemplateId(template);
    }
  }
}
