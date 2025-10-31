using System.ComponentModel.DataAnnotations;

namespace Desafio_Atendimento_CRM.Models
{
    public class Fornecedores
    {
        [Key]
        public int? Forn_Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; } = string.Empty;

        public Fornecedores(string nome, string cnpj, string email, string tipo) 
        {
            Nome = nome;
            Cnpj = cnpj;
            Email = email;
        }
    }
}
