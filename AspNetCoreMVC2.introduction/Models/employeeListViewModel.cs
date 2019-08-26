using System.Collections.Generic;
using AspNetCoreMVC2.introduction.Entities;

namespace AspNetCoreMVC2.introduction.Models
{
    public class employeeListViewModel
    {
        public employeeListViewModel()
        {
        }

        public List<Employee> Employees { get; set; }
        public object Cities { get; set; }
    }
}