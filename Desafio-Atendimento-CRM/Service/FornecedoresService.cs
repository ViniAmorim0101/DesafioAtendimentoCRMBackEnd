using Desafio_Atendimento_CRM.Repository;
using Desafio_Atendimento_CRM.Models;

namespace Desafio_Atendimento_CRM.Service
{
    public class FornecedoresService : IFornecedoresService
    {
        private readonly IFornecedoresRepository _fornecedoresRepository;

        public FornecedoresService(IFornecedoresRepository fornecedoresRepository)
        {
            _fornecedoresRepository = fornecedoresRepository;
        }

        public async Task<IEnumerable<Fornecedores>> BuscarFornecedoresServiceAsync()
        {
            return await _fornecedoresRepository.BuscarFornecedoresRepAsync();
        }

        public async Task<Fornecedores> BuscarFornecedoresPorIdServiceAsync(int id)
        {
            var fornecedor = await _fornecedoresRepository.BuscarFornecedoresPorIdRepAsync(id);
            return fornecedor;
        }

        public async Task<Fornecedores> CriarFornecedorServiceAsync(Fornecedores fornecedor)
        {
            var novoFornecedor = await _fornecedoresRepository.CriarFornecedorRepAsync(fornecedor);
            return novoFornecedor;
        }

        public async Task<Fornecedores> AtualizarFornecedorServiceAsync(int id, Fornecedores fornecedor)
        {
            var fornecedorExistente = await _fornecedoresRepository.BuscarFornecedoresPorIdRepAsync(id);
            if (fornecedorExistente == null)
            {
                return null;
            }
            fornecedorExistente.Nome = fornecedor.Nome;
            fornecedorExistente.Cnpj = fornecedor.Cnpj;
            fornecedorExistente.Telefone = fornecedor.Telefone;
            fornecedorExistente.Email = fornecedor.Email;

            var fornecedorAtualizado = await _fornecedoresRepository.AtualizarFornecedorRepAsync(fornecedorExistente);
            return fornecedorAtualizado;
        }
        public async Task<bool> ExcluirFornecedorServiceAsync(int id)
        {
            var fornecedorExistente = await _fornecedoresRepository.BuscarFornecedoresPorIdRepAsync(id);
            if (fornecedorExistente == null)
            {
                return false;
            }
            return await _fornecedoresRepository.ExcluirFornecedorRepAsync(id);
        }
    }
}
