using MvcApp.Data;
using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class AngularController : Controller
    {
        // GET: Angular
        public ActionResult Index()
        {
            // fetch some data
            var context = new DrumsContext();
            var data = context.Drumset
                .OrderBy(x => x.Manufacturer).ToList();
            var model = new DrumsetsViewModel
            {
                Drumsets = data
            };
            return View(model);
        }
    }
}