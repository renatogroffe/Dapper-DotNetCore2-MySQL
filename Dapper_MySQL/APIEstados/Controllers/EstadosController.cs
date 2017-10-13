using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace APIEstados.Controllers
{
    [Route("api/[controller]")]
    public class EstadosController : Controller
    {
        [HttpGet]
        public IEnumerable<Estado> Get(
            [FromServices]EstadosDAO estadosDAO)
        {
            return estadosDAO.ListarTodos();
        }
    }
}