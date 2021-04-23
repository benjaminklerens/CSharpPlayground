using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpPlayground.Controllers
{
    public class BenjaminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
