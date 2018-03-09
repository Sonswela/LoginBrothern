using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class EmployeeService
    {
        private EmployeeRepository repository;

        public EmployeeService()
        {
            repository = new EmployeeRepository();
        }
        public List<Employee> GetAllEmployees()
        {
            return repository.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return repository.GetEmployeeByID(id);
        }

        public void AddEmployee(Employee toAdd)
        {
            repository.AddEmployee(toAdd);
        }

        public void DeleteEmployee(Employee toDelete)
        {
            repository.DeleteEmployee(toDelete);
        }

        public List<Employee> GetEmployeeByWorkLength(int yearsWorked)
        {
            List<Employee> filteredList = GetAllEmployees();
            //Filter list here
            for (int i = 0; i < filteredList.Count; i++)
            {
                int employeeYearsWorked = DateTime.Now.Year - filteredList[i].hireDate.Year;
                if(employeeYearsWorked <= yearsWorked)
                {
                    filteredList.Remove(filteredList[i]);
                }
            }
            return filteredList;
        }
    }
}