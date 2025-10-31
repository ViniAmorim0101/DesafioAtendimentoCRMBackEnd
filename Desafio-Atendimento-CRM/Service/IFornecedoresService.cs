using Desafio_Atendimento_CRM.Models;

namespace Desafio_Atendimento_CRM.Service
{
    // Interface deve ser usada para definir contratos, não classes.
    public interface IFornecedoresService
    {
        Task<IEnumerable<Fornecedores>> BuscarFornecedoresServiceAsync();
        Task<Fornecedores> BuscarFornecedoresPorIdServiceAsync(int id);
        Task<Fornecedores> CriarFornecedorServiceAsync(Fornecedores fornecedor);
        Task<Fornecedores> AtualizarFornecedorServiceAsync(int id, Fornecedores fornecedor);
        Task<bool> ExcluirFornecedorServiceAsync(int id);
    }
}
