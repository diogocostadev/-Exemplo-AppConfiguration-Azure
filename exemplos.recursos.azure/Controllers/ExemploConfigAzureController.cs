using Microsoft.AspNetCore.Mvc;

namespace exemplos.recursos.azure.Controllers;

[ApiController]
[Route("[controller]")]
public class ExemploConfigAzureController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public ExemploConfigAzureController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    [Route("recuperar-configuracao")]
    public IResult RecuperarConfiguracao()
    {
        var chave1 = _configuration["empresa-projeto-chave"];
        var chave2 = _configuration["empresa:projeto:chave"];
        return Results.Ok(new { Valor1 = chave1, Valor2 = chave2 });
    }
}