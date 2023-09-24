using API.Models.Entities;

namespace API.Repositories.IRepos
{
    public interface IEmployeeRepo
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<bool> HasEmployee(int id);
    }
}
