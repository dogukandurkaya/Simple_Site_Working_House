using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Working_House.Controllers
{
    public class UrunlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
