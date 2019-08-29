using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC2.introduction.Filter
{
    public class CustomerFilter : Attribute, IActionFilter 
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            int i = 1;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            int i2 = 11;
        }
    }
}
