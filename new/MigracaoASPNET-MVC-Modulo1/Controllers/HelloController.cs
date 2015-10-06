using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MigracaoASPNET_MVC_Modulo1.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Eco()
        {
            return View();
        }
    }
}
