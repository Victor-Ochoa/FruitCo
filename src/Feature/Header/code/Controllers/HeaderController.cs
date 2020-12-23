using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FruitCo.Feature.Header.Controllers
{
    public class HeaderController : Controller, IController
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}