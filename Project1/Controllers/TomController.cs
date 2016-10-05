using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataModel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    public class TomController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new MyContext().Tom.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            var model = new Tom();
            return View(model);
        }

        public IActionResult Detail(string id)
        {
            var model = new MyContext().Tom.FirstOrDefault(x => x.Name == id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Tom model)
        {
            var context = new MyContext();

            var existing = context.Tom.FirstOrDefault(x => x.Name == model.Name);

            if (existing == null)
            {
                context.Tom.Add(model);
            } else
            {
                existing = model;
            }

            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
