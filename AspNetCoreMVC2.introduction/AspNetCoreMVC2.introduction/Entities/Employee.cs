using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC2.introduction.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
    }
}
