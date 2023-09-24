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
    public class DepartmentHistoriesController : ControllerBase
    {
        private readonly IDepartmentHistoryRepo _departmentHistoryRepo;

        public DepartmentHistoriesController(IDepartmentHistoryRepo departmentHistoryRepo)
        {
            _departmentHistoryRepo = departmentHistoryRepo;
        }

        // GET: api/DepartmentHistories
        [HttpGet("dp-history")]
        public async Task<ActionResult<IEnumerable<DepartmentHistory>>> GetDepartmentHistories()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(await _departmentHistoryRepo.GetDepartmentHistories());
        }

        // GET: api/DepartmentHistories/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<DepartmentHistory>> GetDepartmentHistory(int id)
        //{
        //  if (_context.DepartmentHistories == null)
        //  {
        //      return NotFound();
        //  }
        //    var departmentHistory = await _context.DepartmentHistories.FindAsync(id);

        //    if (departmentHistory == null)
        //    {
        //        return NotFound();
        //    }

        //    return departmentHistory;
        //}

        // PUT: api/DepartmentHistories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDepartmentHistory(int id, DepartmentHistory departmentHistory)
        //{
        //    if (id != departmentHistory.DepartmentHistoryId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(departmentHistory).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DepartmentHistoryExists(id))
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

        // POST: api/DepartmentHistories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<DepartmentHistory>> PostDepartmentHistory(DepartmentHistory departmentHistory)
        //{
        //  if (_context.DepartmentHistories == null)
        //  {
        //      return Problem("Entity set 'EmployeeDbContext.DepartmentHistories'  is null.");
        //  }
        //    _context.DepartmentHistories.Add(departmentHistory);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetDepartmentHistory", new { id = departmentHistory.DepartmentHistoryId }, departmentHistory);
        //}

        // DELETE: api/DepartmentHistories/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteDepartmentHistory(int id)
        //{
        //    if (_context.DepartmentHistories == null)
        //    {
        //        return NotFound();
        //    }
        //    var departmentHistory = await _context.DepartmentHistories.FindAsync(id);
        //    if (departmentHistory == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.DepartmentHistories.Remove(departmentHistory);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}
    }
}
