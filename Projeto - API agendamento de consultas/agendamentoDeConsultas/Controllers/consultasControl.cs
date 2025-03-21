using Microsoft.AspNetCore.Mvc;
using agendamentoDeConsultas.Models;

namespace agendamentoDeConsultas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class consultasControl
    {
        private static List<Consulta> __consultas = new List<Consulta>();

        
    }
}