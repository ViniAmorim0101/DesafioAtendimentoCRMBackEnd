using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_Atendimento_CRM.Models
{
    public class Fornecedores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Tipo { get; set; } = string.Empty;

        public Fornecedores(string nome, string cnpj, string telefone, string email, string tipo) 
        {
            Nome = nome;
            Cnpj = cnpj;
            Telefone = telefone;
            Email = email;
            Tipo = tipo;
        }
    }
}
