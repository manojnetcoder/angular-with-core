using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace angular_with_core.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private static string[] EmployeeList = new[] {
            "Employee 1", "Employee 2", "Employee 3", "Employee 4","Employee 5"
        };

        private static string[] CourseList = new[] {
            "Dot Net", "Java", "PHP", "Python", "Ruby", "C++"
        };
        
        [HttpGet("[action]")]
        public IEnumerable<Employee> EmployeeListGet()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Employee
            {
                EmployeeName = EmployeeList[rng.Next(EmployeeList.Length)],
                Age = rng.Next(15,55),
                Course = CourseList[rng.Next(CourseList.Length)]
            });
        }

        public class Employee
        {
            public string EmployeeName { get; set; }
            public int Age { get; set; }
            public string Course { get; set; }
        }
    }    
}