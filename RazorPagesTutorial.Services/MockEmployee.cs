using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RazorPagesTutorial.Models;

namespace RazorPagesTutorial.Services
{
    public class MockEmployee : IEmployeeRepository
    {
        private readonly List<Employee> _listOfEmployees;
        public MockEmployee()
        {
            _listOfEmployees = new List<Employee>()
            {
                new Employee(){Id=1, Name="Mary", Department= Dept.HR, Email="mary@gmail.com"},
                new Employee(){Id=2, Name="John", Department= Dept.IT, Email="john@yahoo.com", PhotoPath="carousel 1.jpg"},
                new Employee(){Id=3, Name="Peter", Department= Dept.Payroll, Email="mary@outlook.com", PhotoPath="carousel 14.jpg"},
                new Employee(){Id=4, Name="Alexa", Department= Dept.HR, Email="alexa@hotmail.com"}
            };
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = _listOfEmployees.FirstOrDefault((emp) => emp.Id == id);
            return employee;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _listOfEmployees;
        }

        public Employee Update(Employee employeeUpdated)
        {
            Employee employee = _listOfEmployees.FirstOrDefault((emp) => emp.Id == employeeUpdated.Id);
            if(employee != null)
            {
                employee.Name = employeeUpdated.Name;
                employee.Email = employeeUpdated.Email;
                employee.Department = employeeUpdated.Department;
                employee.PhotoPath = employeeUpdated.PhotoPath;
            }
            return employee;
        }
    }
}
