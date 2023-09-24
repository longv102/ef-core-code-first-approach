namespace API.Models.Entities
{
    public class Department
    {
        public string? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? Description { get; set; }
        public List<DepartmentHistory>? DepartmentHistory { get; set; }
    }
}
