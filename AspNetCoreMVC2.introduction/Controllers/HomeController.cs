using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC2.introduction.Entities;
using AspNetCoreMVC2.introduction.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCoreMVC2.introduction.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello MTS";
        }
        public ViewResult Index2()
        {
            return View();
        }
        public ViewResult Index3()
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee{CityId  = 42, Id=1,Name="mts"},
                new Employee{CityId  = 42, Id=2,Name="bahar"},
                new Employee{CityId  = 1    , Id=3,Name="furki"}

            };
            List<string> cities = new List<string>() { "manisa", "konya" };


            var Model = new employeeListViewModel()
            {
                Employees = Employees,
                Cities = cities
            };
            return View(Model);
        }

        public IActionResult Index4()
        {
            return RedirectToAction("Index3"); 
        }

        public JsonResult Index5()
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee{CityId  = 42, Id=1,Name="mts"},
                new Employee{CityId  = 42, Id=2,Name="bahar"},
                new Employee{CityId  = 1    , Id=3,Name="furki"}

            };
            List<string> cities = new List<string>() { "manisa", "konya" };
            return Json(Employees);
        }
        public StatusCodeResult Index6()
        {
            return StatusCode(400);
        }
        public ViewResult RazorDemo()
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee{CityId  = 42, Id=1,Name="mts"},
                new Employee{CityId  = 42, Id=2,Name="bahar"},
                new Employee{CityId  = 1    , Id=3,Name="furki"}

            };
            List<string> cities = new List<string>() { "manisa", "konya" };


            var Model = new employeeListViewModel()
            {
                Employees = Employees,
                Cities = cities
            };
            return View(Model);
        }

        public JsonResult Index7(string key)
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee{CityId  = 42, Id=1,Name="mts"},
                new Employee{CityId  = 42, Id=2,Name="bahar"},
                new Employee{CityId  = 1    , Id=3,Name="furki"}

            };
            if (string.IsNullOrEmpty(key))
            {
                return Json(Employees);
            }

            var result = Employees.Where(e => e.Name.ToLower().Contains(key.ToLower()));
            return Json(result);

            //genelde form datasındandönen veriler işlenir alınır 
        }


        //form datasıyla data bindin yapalım

        public ViewResult EmployeeForm()
        {
            return View();
        }

        public string RouteData(int ID)
        {
            return ID.ToString();
        }
    }
}