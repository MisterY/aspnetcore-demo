using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApp.Data
{
    public class Drumset
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }
    }
}