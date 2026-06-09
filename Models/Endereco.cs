using System.ComponentModel.DataAnnotations;

namespace CadastroAlunosMVC.Models
{
    public class Endereco
    {
        [Required]
        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }
    }
}