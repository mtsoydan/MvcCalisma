using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC2.introduction.Controllers
{
    public class CommonController : Controller
    {
        [Route("/error")]
        public IActionResult Index()
        {
            return View();
        }
    }
}