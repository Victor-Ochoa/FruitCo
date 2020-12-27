using FruitCo.Foundation.EnterpriseStructure.Interface;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FruitCo.Feature.Logo.Controllers
{
  public class LogoController : Controller
  {
        private readonly IEnterprise _enterprise;
        private readonly ISite _site;

        public LogoController(): this(ServiceLocator.ServiceProvider.GetService<IEnterprise>(), ServiceLocator.ServiceProvider.GetService<ISite>())
        {

        }

        public LogoController(IEnterprise enterprise, ISite site)
        {
            this._enterprise = enterprise;
            this._site = site;
        }
    // GET: Default
    public ActionResult Index()
    {
      ViewBag.Enterprise = _enterprise.GetEnterpriseFromCurrentSite();
      ViewBag.SiteUrl = _site.GetStartUrl();
      return View();
    }
  }
}