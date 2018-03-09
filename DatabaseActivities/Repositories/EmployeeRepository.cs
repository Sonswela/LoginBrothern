using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Repositories
{
    public class EmployeeRepository
    {
        private ApplicationDbContext context;

        public EmployeeRepository()
        {
            context = new ApplicationDbContext();
        }
        public List<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }
        public void AddEmployee(Employee toAdd)
        {
            context.Employees.Add(toAdd);
            context.SaveChanges();
        }
        public Employee GetEmployeeByID(int id)
        {
            return context.Employees.Find(id);
        }
        public void DeleteEmployee(Employee toDelete)
        {
            context.Employees.Remove(toDelete);
            context.SaveChanges();
        }
    }
}