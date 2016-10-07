using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApp.Data;

namespace MvcApp.Controllers
{
    [Authorize]
    public class CymbalController : ApiController
    {
        public List<Cymbal> GetCymbals()
        {
            return new DrumsContext().Cymbal.ToList();
        }

        public List<Cymbal> GetCymbalsBySize(decimal size)
        {
            return new DrumsContext().Cymbal.Where(c => c.Size == size).ToList();
        }

        public IHttpActionResult AddCymbal(Cymbal cymbal)
        {
            var context = new DrumsContext();
            context.Cymbal.Add(cymbal);
            context.SaveChanges();
            return Ok(cymbal);
        }  
    }
}
