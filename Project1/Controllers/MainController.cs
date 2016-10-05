using Microsoft.AspNetCore.Mvc;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using WebApp.Config;

namespace Project1.Controllers
{
    public class MainController : Controller
    {
        public MainController(IOptions<StuffConfig> config)
        {
            this.Configuration = config.Value;
            // test
        }

        private StuffConfig Configuration { get; set; }

        public ActionResult Index()
        {
            // read configuration
            
            var model = new Model()
            {
                SomeProperty = this.Configuration.Credentials.Password
            };
            return View(model);
        }
    }
}
