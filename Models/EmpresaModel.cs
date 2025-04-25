using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIConsultaCNPJ.Models
{
    public class EmpresaModel
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("abertura")]
        public string? Abertura { get; set; }

        [JsonProperty("situacao")]
        public string? Situacao { get; set; }

        [JsonProperty("tipo")]
        public string? Tipo { get; set; }

        [JsonProperty("nome")]
        public string? Nome { get; set; }

        [JsonProperty("natureza_juridica")]
        public string? NaturezaJuridica { get; set; }

        [JsonProperty("logradouro")]
        public string? Logradouro { get; set; }

        [JsonProperty("numero")]
        public string? Numero { get; set; }

        [JsonProperty("complemento")]
        public string? Complemento { get; set; }

        [JsonProperty("municipio")]
        public string? Municipio { get; set; }

        [JsonProperty("bairro")]
        public string? Bairro { get; set; }

        [JsonProperty("uf")]
        public string? Uf { get; set; }

        [JsonProperty("cep")]
        public string? Cep { get; set; }

        [JsonProperty("cnpj")]
        public string? Cnpj { get; set; }

        [JsonProperty("fantasia")]
        public string? Fantasia { get; set; }

        [NotMapped]
        [JsonProperty("atividade_principal")]
        public List<AtividadePrincipal>? ListaAtividadesPrincipais { get; set; }

        public string? AtividadePrincipal { get; set; }
        public int UserId { get; set; }
    }

    public class AtividadePrincipal
    {
        [JsonProperty("text")]
        public string? Texto { get; set; }

        [JsonProperty("code")]
        public string? Codigo { get; set; }
    }
}
