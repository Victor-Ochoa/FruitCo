using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FruitCo.Feature.Header.Controllers
{
    public class HeaderController : SitecoreController
  {
        // GET: Default
        public override ActionResult Index()
        {
            return View();
        }
    }
}