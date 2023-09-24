namespace API.Models.Entities
{
    public class DepartmentHistory
    {
        public int DepartmentHistoryId { get; set; }
        public int EmployeeId { get; set; }
        public string? DepartmentId { get; set; }
        public bool Available { get; set; }
        public Employee? Employee { get; set; }
        public Department? Department { get; set; }
    }
}
