using ControleDeHoras.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeHoras.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegistroController : ControllerBase
{
    private readonly ILogger<RegistroController> _logger;

    public RegistroController(ILogger<RegistroController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Registro> ObterTodosRegistros()
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public IEnumerable<Registro> ObterRegistroPorId()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult CriarRegistro(Registro registro)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public IEnumerable<Registro> DeletarRegistroRegistro()
    {
        throw new NotImplementedException();
    }
}

