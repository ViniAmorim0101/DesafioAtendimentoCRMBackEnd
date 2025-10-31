using Desafio_Atendimento_CRM.Models;
using Desafio_Atendimento_CRM.Service;
using Microsoft.AspNetCore.Mvc;


namespace Desafio_Atendimento_CRM.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FornecedoresController : ControllerBase
    {
        private readonly IFornecedoresService _fornecedoresService;

        public FornecedoresController(IFornecedoresService fornecedoresService)
        {
            _fornecedoresService = fornecedoresService;
        }
       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fornecedores>>> BuscarFornecedoresAsync()
        {
            try
            {
                var fornecedores = await _fornecedoresService.BuscarFornecedoresServiceAsync();
                return Ok(fornecedores);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Não foi possivel obter a listagem de fornecedores: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fornecedores>> BuscarFornecedoresPorIdAsync(int id)
        {
            try
            {
                var fornecedores = await _fornecedoresService.BuscarFornecedoresPorIdServiceAsync(id);
                return Ok(fornecedores);
            } 
            catch (Exception ex)
            {
                return StatusCode(500, $"Não foi possivel obter o fornecedor: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Fornecedores>> CriarFornecedorAsync([FromBody] Fornecedores fornecedor)
        {
            try
            {
                var novoFornecedor = await _fornecedoresService.CriarFornecedorServiceAsync(fornecedor);
                return Ok(novoFornecedor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Não foi possivel cadastrar o Fornecedor: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Fornecedores>> AtualizarFornecedorAsync(int id, Fornecedores fornecedor)
        {
            try
            {
                var fornecedorAtualizado = await _fornecedoresService.AtualizarFornecedorServiceAsync(id, fornecedor);
                return Ok(fornecedorAtualizado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Não foi possivel editar o Fornecedor: {ex.Message}");
            }
        }

        // DELETE api/<FornecedoresController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> ExcluirFornecedorAsync(int id)
        {
            try
            {
                var deletado = await _fornecedoresService.ExcluirFornecedorServiceAsync(id);
                if (!deletado) return NotFound();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Não foi possivel excluir o Fornecedor: {ex.Message}");
            }
        }
    }
}
