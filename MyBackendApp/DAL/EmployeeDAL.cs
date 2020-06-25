﻿using MyBackendApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MyBackendApp.DAL
{
    public class EmployeeDAL
    {
        private string GetConnStr()
        {
            return WebConfigurationManager
                .ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            List<Employee> lstEmployee = new List<Employee>();
            using(SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string strSql = @"select * from Employees order by EmpName asc";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lstEmployee.Add(new Employee
                        {
                            EmpId = Convert.ToInt32(dr["EmpId"]),
                            EmpName = dr["EmpName"].ToString(),
                            Designation = dr["Designation"].ToString(),
                            Department = dr["Department"].ToString(),
                            Qualification = dr["Qualification"].ToString(),
                            BirthDate = Convert.ToDateTime(dr["Birthdate"])
                        });
                    }
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();
            }
            return lstEmployee;
        }


        public Employee GetEmployeeByID(int empId)
        {
            Employee emp = new Employee();
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string strSql = @"select * from Employees where EmpId=@EmpId";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.Parameters.AddWithValue("@EmpId", empId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                    emp.EmpName = dr["EmpName"].ToString();
                    emp.Designation = dr["Designation"].ToString();
                    emp.Department = dr["Department"].ToString();
                    emp.Qualification = dr["Qualification"].ToString();
                    emp.BirthDate = Convert.ToDateTime(dr["Birthdate"]);
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();
            }
            return emp;
        }
    }
}