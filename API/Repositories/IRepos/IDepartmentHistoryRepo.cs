using API.Models.Entities;

namespace API.Repositories.IRepos
{
    public interface IDepartmentHistoryRepo
    {
        Task<IEnumerable<DepartmentHistory>> GetDepartmentHistories();
    }
}
