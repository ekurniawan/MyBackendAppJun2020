using MyBackendApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyBackendApp.Controllers
{
    public class EmployeeController : ApiController
    {
        private List<Employee> lstEmployee = new List<Employee>
        {
            new Employee{EmpId=1,EmpName="Budi",Designation="Mobile Dev",
                Department="IT",Qualification="Android",BirthDate=new DateTime(1990,12,12)},
            new Employee{EmpId=2,EmpName="Bambang",Designation="Mobile Dev",
                Department="IT",Qualification="IOS",BirthDate=new DateTime(1990,11,30)},
            new Employee{EmpId=1,EmpName="Roger",Designation="Web Dev",
                Department="IT",Qualification="Tizen",BirthDate=new DateTime(1990,5,12)}
        };

        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return lstEmployee;
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
