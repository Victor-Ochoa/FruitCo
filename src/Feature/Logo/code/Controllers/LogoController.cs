using FruitCo.Foundation.EnterpriseStructure.Interface;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FruitCo.Feature.Logo.Controllers
{
  public class LogoController : SitecoreController
  {
        private readonly IEnterprise _enterprise;
        private readonly ISite _site;

        public LogoController(IEnterprise enterprise, ISite site)
        {
            this._enterprise = enterprise;
            this._site = site;
        }
    // GET: Default
    public override ActionResult Index()
    {
      ViewBag.Enterprise = _enterprise.GetEnterpriseFromCurrentSite(RenderingContext.Current.Rendering.Item);
      ViewBag.SiteUrl = _site.GetStartUrl();
      return View();
    }
  }
}