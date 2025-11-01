using System.ComponentModel.DataAnnotations;

namespace Desafio_Atendimento_CRM.DTOs
{
    public class ExportarFornecedoresDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public string StatusValidacao { get; set; }
        public int AnosDeAtividade { get; set; }
        public int QuantidadeDeReclamacoes { get; set; }

    }
}
