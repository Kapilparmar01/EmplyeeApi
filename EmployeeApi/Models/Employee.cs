namespace EmployeeApi.Models
{
    public class Employee
    {
        public required string EmployeeId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Department { get; set; }
        public required string Address { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime Dob { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }
    }
}
