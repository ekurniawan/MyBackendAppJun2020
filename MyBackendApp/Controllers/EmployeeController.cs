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
            return empDAL.GetEmployeeByID(id);
        }

        // POST: api/Employee
        public IHttpActionResult Post(Employee emp)
        {
            try
            {
                empDAL.InsertEmployee(emp);
                return Ok("Data berhasil ditambahkan !");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Employee/5
        public IHttpActionResult Put(Employee emp)
        {
            try
            {
                empDAL.EditEmployee(emp);
                return Ok("Data berhasil diedit");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
