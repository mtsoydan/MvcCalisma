using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC2.introduction.Filter;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC2.introduction.Controllers
{
    public class FilterController : Controller
    {
        [CustomerFilter]
        public IActionResult Index()
        {
            return View();
        }
    }
} 