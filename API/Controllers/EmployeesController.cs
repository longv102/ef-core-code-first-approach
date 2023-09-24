using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Context;
using API.Models.Entities;
using API.Repositories.IRepos;

namespace API.Controllers
{
    [Route("api/employee-management")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeesController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        // GET: api/Employees
        [HttpGet("employees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(await _employeeRepo.GetEmployees());
        }

        // GET: api/Employees/5
        [HttpGet("employees/{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (!await _employeeRepo.HasEmployee(id)) return NotFound("Employee not found!");
            return Ok(await _employeeRepo.GetEmployee(id));
        }

        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutEmployee(int id, Employee employee)
        //{
        //    if (id != employee.EmployeeId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(employee).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EmployeeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        //{
        //  if (_context.Employees == null)
        //  {
        //      return Problem("Entity set 'EmployeeDbContext.Employees'  is null.");
        //  }
        //    _context.Employees.Add(employee);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetEmployee", new { id = employee.EmployeeId }, employee);
        //}

        // DELETE: api/Employees/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteEmployee(int id)
        //{
        //    if (_context.Employees == null)
        //    {
        //        return NotFound();
        //    }
        //    var employee = await _context.Employees.FindAsync(id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Employees.Remove(employee);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

    }
}
