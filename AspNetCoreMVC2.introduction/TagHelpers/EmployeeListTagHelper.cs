using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreMVC2.introduction.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Primitives;

namespace AspNetCoreMVC2.introduction.TagHelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper : TagHelper
    {
        private List<Employee> _employee = new List<Employee>();
        public EmployeeListTagHelper()
        {
         
            _employee = new List<Employee>()
            {
                new Employee{CityId  = 42, Id=1,Name="mts"},
                new Employee{CityId  = 42, Id=2,Name="bahar"},
                new Employee{CityId  = 1    , Id=3,Name="furki"}
            };

        }
        private const string ListCountAttributeName = "count";
        [HtmlAttributeName(ListCountAttributeName)]
        public int Listcount { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            StringBuilder stringbuilder = new StringBuilder();
            output.TagName = "div";
            var query = _employee.Take(Listcount);
            foreach (var employee in query)
            {
                stringbuilder.AppendFormat("<h2><a href='/employee/detail/{0}'>{1}</a></h2>", employee.Id, employee.Name);
            }
            output.Content.SetHtmlContent(stringbuilder.ToString());
            base.Process(context, output);

        }

    }
}
