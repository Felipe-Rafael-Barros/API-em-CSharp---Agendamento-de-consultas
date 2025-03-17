using Microsoft.AspNetCore.Mvc;
using Models;

namespace DevJobsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private static List<Job> _jobs = new List<Job>();

        [HttpGet]
        public IActionResult GetJobs()
        {
            return Ok(_jobs); // Retorna todos os jobs
        }

        [HttpGet("{id}")]
        public IActionResult GetJob(int id)
        {
            var job = _jobs.FirstOrDefault(j => j.Id == id);
            if (job == null) return NotFound();
            return Ok(job); // Retorna o job pelo ID
        }

        [HttpPost]
        public IActionResult CreateJob([FromBody] Job newJob)
        {
            if (newJob == null) return BadRequest();

            newJob.Id = _jobs.Count + 1;
            _jobs.Add(newJob);
            return CreatedAtAction(nameof(GetJob), new { id = newJob.Id }, newJob); // Retorna o job criado
        }
    }
}
