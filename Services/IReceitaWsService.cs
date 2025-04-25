using APIConsultaCNPJ.Models;

namespace APIConsultaCNPJ.Services
{
    public interface IReceitaWsService
    {
        Task<EmpresaModel?> ConsultarCnpjAsync(string cnpj);
    }
}