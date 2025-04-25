using APIConsultaCNPJ.Models;
using Newtonsoft.Json;

namespace APIConsultaCNPJ.Services
{
    public class ReceitaWsService : IReceitaWsService
    {
        private readonly HttpClient _httpClient;

        public ReceitaWsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<EmpresaModel?> ConsultarCnpjAsync(string cnpj)
        {
            var response = await _httpClient.GetAsync($"https://www.receitaws.com.br/v1/cnpj/{cnpj}");

            if (!response.IsSuccessStatusCode)
                return null;

            var content = await response.Content.ReadAsStringAsync();
            var empresa = JsonConvert.DeserializeObject<EmpresaModel>(content);

            if (empresa.ListaAtividadesPrincipais != null && empresa.ListaAtividadesPrincipais.Any())
                empresa.AtividadePrincipal = empresa.ListaAtividadesPrincipais.First().Texto;

            return empresa;
        }
    }
}
