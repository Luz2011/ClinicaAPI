using Microsoft.AspNetCore.Mvc;
using ClinicaAPI.Data;
using ClinicaAPI.Models;
using System.Linq;

namespace ClinicaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private readonly ClinicaContext _context;

        public PacientesController(ClinicaContext context)
        {
            _context = context;
        }

        // GET: api/pacientes
        [HttpGet]
        public IActionResult Get()
        {
            var pacientes = _context.Pacientes.ToList();
            return Ok(pacientes);
        }

        // POST: api/pacientes
        [HttpPost]
        public IActionResult Post([FromBody] Paciente paciente)
        {
            if (paciente == null)
            {
                return BadRequest();
            }

            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
            return Ok(paciente);
        }
    }
}