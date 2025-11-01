using System.ComponentModel.DataAnnotations;

namespace Desafio_Atendimento_CRM.DTOs
{
    public class CriarFornecedoresDto
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
      
    }
}
