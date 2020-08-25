using System;
using System.Collections.Generic;
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
                new Employee(){Id=1, Name="Mary", Department= Dept.HR, Email="mary@gmail.com", PhotoPath="jjc.jpg"},
                new Employee(){Id=2, Name="John", Department= Dept.IT, Email="john@yahoo.com", PhotoPath="la.jpg"},
                new Employee(){Id=3, Name="Peter", Department= Dept.Payroll, Email="mary@outlook.com", PhotoPath="carousel 14.jpg"},
                new Employee(){Id=4, Name="Alexa", Department= Dept.HR, Email="alexa@hotmail.com"}
            };
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _listOfEmployees;
        }
    }
}
