using API.Context;
using API.Models.Entities;
using API.Repositories.IRepos;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories.Repos
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepo(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _context.Employees.OrderByDescending(e => e.Salary).ToListAsync();
        }

        public async Task<bool> HasEmployee(int id)
        {
            return await _context.Employees.AnyAsync(e => e.EmployeeId == id);
        }
    }
}
