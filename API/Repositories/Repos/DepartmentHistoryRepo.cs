using API.Context;
using API.Models.Entities;
using API.Repositories.IRepos;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories.Repos
{
    public class DepartmentHistoryRepo : IDepartmentHistoryRepo
    {
        private readonly EmployeeDbContext _context;

        public DepartmentHistoryRepo(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DepartmentHistory>> GetDepartmentHistories()
        {
            return await _context.DepartmentHistories.ToListAsync();    
        }
    }
}
