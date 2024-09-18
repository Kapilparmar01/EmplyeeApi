using EmployeeApi.Data;
using EmployeeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository _repository;

        public EmployeeController()
        {
            _repository = new EmployeeRepository();
        }

        [HttpGet("filterByDepartment")]
        public ActionResult<IEnumerable<Employee>> FilterByDepartment([FromQuery] string department)
        {
            var employees = _repository.GetEmployeesByDepartment(department);
            return Ok(employees);
        }

        [HttpGet("sortBySalary")]
        public ActionResult<IEnumerable<Employee>> SortBySalary()
        {
            var employees = _repository.GetEmployeesSortedBySalary();
            return Ok(employees);
        }

        [HttpGet("searchById")]
        public ActionResult<Employee> SearchById([FromQuery] string employeeId)
        {
            var employee = _repository.GetEmployeeById(employeeId);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
