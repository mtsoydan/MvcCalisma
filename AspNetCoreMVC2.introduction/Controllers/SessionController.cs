using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC2.introduction.Controllers
{
    public class SessionController : Controller
    {
        public string Index()
        {

            HttpContext.Session.SetInt32("Age", 22);
            HttpContext.Session.SetString("Name", "MustafaTahaSoydan");
            return "session created";
        }
        public string GetSession()
        {
            return string.Format("{0} , you are {1} age", HttpContext.Session.GetString("Name"), HttpContext.Session.GetInt32("Age"));

        }
    }
}