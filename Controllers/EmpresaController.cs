using APIConsultaCNPJ.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using APIConsultaCNPJ.Data;

namespace APIConsultaCNPJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] 
    public class EmpresasController : ControllerBase
    {
        private readonly IReceitaWsService _receitaWsService;
        private readonly AppDbContext _context;

        public EmpresasController(IReceitaWsService receitaWsService, AppDbContext context)
        {
            _receitaWsService = receitaWsService;
            _context = context;
        }

        [HttpPost("{cnpj}")]
        public async Task<IActionResult> CadastrarEmpresaPorCnpj(string cnpj)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (string.IsNullOrEmpty(userId))
                    return Unauthorized("Usuário não autenticado.");

                var empresa = await _receitaWsService.ConsultarCnpjAsync(cnpj);

                if (empresa == null)
                    return BadRequest("Erro ao consultar CNPJ na ReceitaWS.");

                empresa.UserId = int.Parse(userId);

                _context.Empresas.Add(empresa);
                await _context.SaveChangesAsync();

                return Ok(empresa);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno: {ex.Message}");
            }
        }
    }
}
