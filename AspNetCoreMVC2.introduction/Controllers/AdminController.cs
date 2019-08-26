using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC2.introduction.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("")]
        public string Add()
        {
            return "Eklendi";
        }

        [Route("Delete")]
        public string Delete()
        {
            return "Silindi";
        }
        [Route("Update")]
        public string Update()
        {
            return "Update Edildi";
        }
    }
}