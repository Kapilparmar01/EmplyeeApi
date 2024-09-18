using EmployeeApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeApi.Data
{
    public class EmployeeRepository
    {
        private readonly List<Employee> _employees;

        public EmployeeRepository()
        {
            _employees = new List<Employee>
            {
                new Employee { EmployeeId = "123", FirstName = "John", LastName = "Doe", Department = "IT", Address = "123 Street", HireDate = new DateTime(2023, 2, 1), Dob = new DateTime(2012, 2, 1), JoiningDate = new DateTime(2023, 2, 20), Salary = 123 },
                // Add more employees here
            };
        }

        public IEnumerable<Employee> GetEmployees() => _employees;

        public IEnumerable<Employee> GetEmployeesByDepartment(string department) =>
            _employees.Where(e => e.Department.Equals(department, StringComparison.OrdinalIgnoreCase));

        public IEnumerable<Employee> GetEmployeesSortedBySalary() =>
            _employees.OrderBy(e => e.Salary);

        public Employee GetEmployeeById(string employeeId) =>
            _employees.SingleOrDefault(e => e.EmployeeId.Equals(employeeId, StringComparison.OrdinalIgnoreCase));
    }
}
