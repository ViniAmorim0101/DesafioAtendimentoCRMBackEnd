using Desafio_Atendimento_CRM.Models;

namespace Desafio_Atendimento_CRM.Repository
{
    public interface IFornecedoresRepository
    {
        Task<IEnumerable<Fornecedores>> BuscarFornecedoresRepAsync();
        Task<Fornecedores> BuscarFornecedoresPorIdRepAsync(int id);
        Task<Fornecedores> CriarFornecedorRepAsync(Fornecedores fornecedor);
        Task<Fornecedores> AtualizarFornecedorRepAsync(Fornecedores fornecedor);
        Task<bool> ExcluirFornecedorRepAsync(int id);
    }
}
