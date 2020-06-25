using MyBackendApp.DAL;
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
        private EmployeeDAL empDAL;
        public EmployeeController()
        {
            empDAL = new EmployeeDAL();
        }

        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return empDAL.GetAllEmployee();
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            return new Employee();
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
