﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVC2.introduction.ExtensionMethod;
using AspNetCoreMVC2.introduction.Entities;

namespace AspNetCoreMVC2.introduction.Controllers
{
    public class SessionController : Controller
    {
        public string Index()
        {

            HttpContext.Session.SetInt32("Age", 22);
            HttpContext.Session.SetString("Name", "MustafaTahaSoydan");
            HttpContext.Session.SetObject("student",new Student { FirstName = "mustafa taha", ID = 1, LastName = "soydan-" });
            return "session created";
        }
        public string GetSession()
        {
            return string.Format("{0} , you are {1} age ---- {2}", HttpContext.Session.GetString("Name"), HttpContext.Session.GetInt32("Age"),HttpContext.Session.GetObject<Student>("student").FirstName);

        }
    }
}