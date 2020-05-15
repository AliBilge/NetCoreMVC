using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreAir.Controller
{
    public class AirController : Controller
    {
        public IActionResult Index()
        {
            var model = new AirViewModel()
            {
                AspNetCoreAir = aspnetcoreair
            };
            return View(model);
        }
    }
}