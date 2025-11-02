using DocumentValidator;
using System.Security.Cryptography.X509Certificates;

namespace Desafio_Atendimento_CRM.Service.Servicos_Fornecedores
{
    public class ValidadorFornecedorService
    {
        public bool CnpjValido(string cnpj)
        {
            var CNPJValidado = CnpjValidation.Validate(cnpj);
            return CNPJValidado;
        }

        public bool ValidarSeEstaBloqueado(string cnpj)
        {
            List<string> listaCnpjsBloqueados = new List<string>
            {
                "00.000.000/0000-00",
                "11.111.111/1111-11",
                "22.222.222/2222-22",
                "33.333.333/3333-33",
                "44.444.444/4444-44",
                "55.555.555/5555-55",
                "66.666.666/6666-66",
                "77.777.777/7777-77",
                "88.888.888/8888-88",
                "99.999.999/9999-99"
            };

            bool cnpjExiste = listaCnpjsBloqueados.Contains(cnpj);

            return cnpjExiste;
        }

        public bool MaisDe2AnosDeAtividade(int anosDeAtividade)
        {
            bool temMaisDe2Anos = anosDeAtividade > 2;
            return temMaisDe2Anos;
        }

        public string RiscoDeReclamacoes(int quantidadeDeReclamacoes)
        {
            if (quantidadeDeReclamacoes > 3)
            { return "Alto Risco"; }
            else if (quantidadeDeReclamacoes >= 1 && quantidadeDeReclamacoes < 3)
            { return "Médio Risco"; }
            else
            { return "Baixo Risco";}
            
        }
    }
}