namespace API.Models.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? CompanyName { get; set; }
        public string? Designation { get; set; }
        public float Salary { get; set; }
        public List<DepartmentHistory>? DepartmentHistory { get; set; }
    }
}
