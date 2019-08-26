using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC2.introduction.Entities;
using AspNetCoreMVC2.introduction.Models;
using AspNetCoreMVC2.introduction.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreMVC2.introduction.Controllers
{
    public class EmployeeController : Controller
    {
        private ICalculator _Icalculate;
        public EmployeeController(ICalculator Calculate)
        {
            _Icalculate = Calculate;
        }
        public IActionResult Add()
        {
            var employeeAddviewModel = new EmployeeAddViewModel()
            {
                Employee = new Employee(),
                Cities = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>
                {
                    new SelectListItem{ Text="Konya",Value ="42"},
                    new SelectListItem{ Text="Mugla",Value ="54"},
                    new SelectListItem{ Text="İstanbul",Value ="34"}
                }
            };
            return View(employeeAddviewModel);
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return View();
        }

        public string Calculate()
        {

            return _Icalculate.Caltulate(100).ToString();
        }
    }
}