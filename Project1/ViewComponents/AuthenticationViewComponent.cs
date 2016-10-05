using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Project1.ViewComponents
{
    public class AuthenticationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var user = User.Identity.Name;

            return View(user);
        }
    }
}
