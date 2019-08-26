using AspNetCoreMVC2.introduction.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AspNetCoreMVC2.introduction.Models
{
    public class EmployeeAddViewModel
    {
        public EmployeeAddViewModel()
        {
        }

        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}