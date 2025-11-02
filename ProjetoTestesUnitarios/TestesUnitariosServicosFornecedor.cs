using Desafio_Atendimento_CRM.Service.Servicos_Fornecedores;

namespace ProjetoTestesUnitarios
{
    public class TestesUnitariosServicosFornecedor
    {
        [Fact]
        public void CnpjValido_ValidarCNPJCorreto_CnpjValido()
        {
            // 1. Arrange (Organizar)
            var validadorFornecedores = new ValidadorFornecedorService();
            string cnpjvalido = "88.071.719/0001-64";

            // 2. Act (Agir)
            bool validacao = validadorFornecedores.CnpjValido(cnpjvalido);

            // 3. Assert (Verificar)
            Assert.Equal(true, validacao);
        }

        [Fact]
        public void CnpjValido_ValidarCNPJIncorreto_CnpjInvalido()
        {
            // 1. Arrange (Organizar)
            var validadorFornecedores = new ValidadorFornecedorService();
            string cnpjinvalido = "00.000.000/0000-00";

            // 2. Act (Agir)
            bool validacao = validadorFornecedores.CnpjValido(cnpjinvalido);

            // 3. Assert (Verificar)
            Assert.Equal(false, validacao);
        }

        [Fact]
        public void ValidarSeEstaBloqueado_ValidarCnpjDesbloqueado_CnpjDesbloqueado()
        {
            // 1. Arrange (Organizar)
            var validadorFornecedores = new ValidadorFornecedorService();
            string cnpjdesbloqueado = "88.071.719/0001-64";

            // 2. Act (Agir)
            bool validacao = validadorFornecedores.ValidarSeEstaBloqueado(cnpjdesbloqueado);

            // 3. Assert (Verificar)
            Assert.Equal(false, validacao);
        }

        [Fact]
        public void ValidarSeEstaBloqueado_ValidarCnpjBloqueado_CnpjBloqueado()
        {
            // 1. Arrange (Organizar)
            var validadorFornecedores = new ValidadorFornecedorService();
            string cnpjbloqueado = "77.777.777/7777-77";

            // 2. Act (Agir)
            bool validacao = validadorFornecedores.ValidarSeEstaBloqueado(cnpjbloqueado);

            // 3. Assert (Verificar)
            Assert.Equal(true, validacao);
        }

        [Fact]
        public void MaisDe2AnosDeAtividade_ValidarSeTemMaisDe2AnosDeAtividade_TemMaisDe2Anos()
        {
            // 1. Arrange (Organizar)
            var validadorFornecedores = new ValidadorFornecedorService();
            int anosdeAtividade = 3;

            // 2. Act (Agir)
            bool validacao = validadorFornecedores.MaisDe2AnosDeAtividade(anosdeAtividade);

            // 3. Assert (Verificar)
            Assert.Equal(true, validacao);
        }

        [Fact]
        public void MaisDe2AnosDeAtividade_ValidarSeTemMaisDe2AnosDeAtividade_NaoTemMaisDe2Anos()
        {
            // 1. Arrange (Organizar)
            var validadorFornecedores = new ValidadorFornecedorService();
            int anosdeAtividade = 1;

            // 2. Act (Agir)
            bool validacao = validadorFornecedores.MaisDe2AnosDeAtividade(anosdeAtividade);

            // 3. Assert (Verificar)
            Assert.Equal(false, validacao);
        }

        [Fact]
        public void RiscoDeReclamacoes_ValidarMedidaDoRisco_AltoRisco()
        {
            // 1. Arrange (Organizar)
            var validadorFornecedores = new ValidadorFornecedorService();
            int quantidadeDeReclamacoes = 5;

            // 2. Act (Agir)
            string validacao = validadorFornecedores.RiscoDeReclamacoes(quantidadeDeReclamacoes);

            // 3. Assert (Verificar)
            Assert.Equal("Alto Risco", validacao);
        }

        [Fact]
        public void RiscoDeReclamacoes_ValidarMedidaDoRisco_MedioRisco()
        {
            // 1. Arrange (Organizar)
            var validadorFornecedores = new ValidadorFornecedorService();
            int quantidadeDeReclamacoes = 2;

            // 2. Act (Agir)
            string validacao = validadorFornecedores.RiscoDeReclamacoes(quantidadeDeReclamacoes);

            // 3. Assert (Verificar)
            Assert.Equal("Médio Risco", validacao);
        }

        [Fact]
        public void RiscoDeReclamacoes_ValidarMedidaDoRisco_BaixoRisco()
        {
            // 1. Arrange (Organizar)
            var validadorFornecedores = new ValidadorFornecedorService();
            int quantidadeDeReclamacoes = 0;

            // 2. Act (Agir)
            string validacao = validadorFornecedores.RiscoDeReclamacoes(quantidadeDeReclamacoes);

            // 3. Assert (Verificar)
            Assert.Equal("Baixo Risco", validacao);
        }
    }
}