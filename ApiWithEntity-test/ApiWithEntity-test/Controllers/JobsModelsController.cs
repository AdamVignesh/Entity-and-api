using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiWithEntity_test.Data;
using ApiWithEntity_test.Models;

namespace ApiWithEntity_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsModelsController : ControllerBase
    {
        private readonly JobDbContext _context;

        public JobsModelsController(JobDbContext context)
        {
            _context = context;
        }

        // GET: api/JobsModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobsModel>>> GetJobsTable()
        {
          if (_context.JobsTable == null)
          {
              return NotFound();
          }
            return await _context.JobsTable.ToListAsync();
        }

        // GET: api/JobsModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobsModel>> GetJobsModel(int id)
        {
          if (_context.JobsTable == null)
          {
              return NotFound();
          }
            var jobsModel = await _context.JobsTable.FindAsync(id);

            if (jobsModel == null)
            {
                return NotFound();
            }

            return jobsModel;
        }

        // PUT: api/JobsModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobsModel(int id, JobsModel jobsModel)
        {
            if (id != jobsModel.id)
            {
                return BadRequest();
            }

            _context.Entry(jobsModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobsModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/JobsModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobsModel>> PostJobsModel(JobsModel jobsModel)
        {
          if (_context.JobsTable == null)
          {
              return Problem("Entity set 'JobDbContext.JobsTable'  is null.");
          }
            _context.JobsTable.Add(jobsModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobsModel", new { id = jobsModel.id }, jobsModel);
        }

        // DELETE: api/JobsModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobsModel(int id)
        {
            if (_context.JobsTable == null)
            {
                return NotFound();
            }
            var jobsModel = await _context.JobsTable.FindAsync(id);
            if (jobsModel == null)
            {
                return NotFound();
            }

            _context.JobsTable.Remove(jobsModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JobsModelExists(int id)
        {
            return (_context.JobsTable?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
