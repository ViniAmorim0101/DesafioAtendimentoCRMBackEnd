using AutoMapper;
using Desafio_Atendimento_CRM.DTOs;
using Desafio_Atendimento_CRM.Models;

namespace Desafio_Atendimento_CRM.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fornecedores, ExportarFornecedoresDto>();
            CreateMap<CriarFornecedoresDto, Fornecedores>();
            CreateMap<EditarFornecedoresDto, Fornecedores>();
        }
    }
}
