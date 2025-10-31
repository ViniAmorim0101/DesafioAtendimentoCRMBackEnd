using Desafio_Atendimento_CRM.Data;
using Desafio_Atendimento_CRM.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio_Atendimento_CRM.Repository
{
    public class FornecedoresRepository : IFornecedoresRepository
    {
        private readonly AppDbContext _context;

        public FornecedoresRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Fornecedores>> BuscarFornecedoresRepAsync()
        {
            return await _context.Fornecedores.ToListAsync();
        }

        public async Task<Fornecedores> BuscarFornecedoresPorIdRepAsync(int id)
        {
            return await _context.Fornecedores.FindAsync(id);
        }
        public async Task<Fornecedores> CriarFornecedorRepAsync(Fornecedores fornecedor)
        {
            _context.Fornecedores.Add(fornecedor);
            await _context.SaveChangesAsync();
            return fornecedor;
        }
        
        public async Task<Fornecedores> AtualizarFornecedorRepAsync(Fornecedores fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);
            await  _context.SaveChangesAsync();
            return fornecedor;
        }

        public async Task<bool> ExcluirFornecedorRepAsync(int id)
        {
            var fornecedor = await _context.Fornecedores.FindAsync(id);
            if (fornecedor == null)
                throw new Exception("Fornecedor não encontrado.");

            _context.Fornecedores.Remove(fornecedor);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
