using AutoMapper;
using Desafio_Atendimento_CRM.DTOs;
using Desafio_Atendimento_CRM.Models;
using Desafio_Atendimento_CRM.Service;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;


namespace Desafio_Atendimento_CRM.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FornecedoresController : ControllerBase
    {
        private readonly IFornecedoresService _fornecedoresService;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedoresService fornecedoresService, IMapper mapper)
        {
            _fornecedoresService = fornecedoresService;
            _mapper = mapper;
        }
       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExportarFornecedoresDto>>> BuscarFornecedoresAsync()
        {
            try
            {
                var fornecedores = await _fornecedoresService.BuscarFornecedoresServiceAsync();
                var fornecedoresDto = _mapper.Map<IEnumerable<ExportarFornecedoresDto>>(fornecedores);
                return Ok(fornecedoresDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Não foi possivel obter a listagem de fornecedores: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExportarFornecedoresDto>> BuscarFornecedoresPorIdAsync(int id)
        {
            try
            {
                var fornecedores = await _fornecedoresService.BuscarFornecedoresPorIdServiceAsync(id);
                var fornecedoresDto = _mapper.Map<ExportarFornecedoresDto>(fornecedores);
                return Ok(fornecedoresDto);
            } 
            catch (Exception ex)
            {
                return StatusCode(500, $"Não foi possivel obter o fornecedor: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<ExportarFornecedoresDto>> CriarFornecedorAsync([FromBody] CriarFornecedoresDto fornecedor)
        {
            try
            {
                var fornecedorEntidade = _mapper.Map<Fornecedores>(fornecedor);
                var novoFornecedor = await _fornecedoresService.CriarFornecedorServiceAsync(fornecedorEntidade);
                var fornecedorExportarDto = _mapper.Map<ExportarFornecedoresDto>(novoFornecedor);
                return Ok(fornecedorExportarDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Não foi possivel cadastrar o Fornecedor: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ExportarFornecedoresDto>> AtualizarFornecedorAsync(int id, EditarFornecedoresDto fornecedor)
        {
            try
            {
                var fornecedorEntidade = _mapper.Map<Fornecedores>(fornecedor);
                var fornecedorAtualizado = await _fornecedoresService.AtualizarFornecedorServiceAsync(id, fornecedorEntidade);
                var fornecedorExportarDto = _mapper.Map<ExportarFornecedoresDto>(fornecedorAtualizado);
                return Ok(fornecedorExportarDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Não foi possivel editar o Fornecedor: {ex.Message}");
            }
        }

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
