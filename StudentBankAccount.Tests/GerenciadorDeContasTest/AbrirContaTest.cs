using System;
using Xunit;

namespace StudentBankAccount.Tests.GerenciadorDeContasTest
{
    public class AbrirContaTest : GerenciadorDeContasBaseTest
    {
        [Fact]
        public void DadaNovaInstancia_QuandoConstrutorEhExecutado_EntaoTotalDeContasCriadasAdicionaContador()
        {
            #region Arrange
            var agencia = 1100;
            var quantidadeDeContas = 5;
            #endregion

            #region Act
            var gerenciador = CriarNovoGerenciadorDeContas(agencia, quantidadeDeContas);
            #endregion

            #region Assert
            Assert.Equal(quantidadeDeContas, gerenciador.TotalDeContasCriadas);
            #endregion
        }

        [Fact]
        public void DadaAberturaDeVariasContas_QuandoConsultaTaxaDeOperacao_EntaoCalculaTaxaOperacao()
        {
            #region Arrange
            var agencia = 1100;
            var quantidadeDeContas = 5;
            #endregion

            #region Act
            var gerenciador = CriarNovoGerenciadorDeContas(agencia, quantidadeDeContas);
            var taxaOperacao = 30 / quantidadeDeContas;
            #endregion

            #region Assert
            Assert.Equal(taxaOperacao, gerenciador.TaxaOperacao);
            #endregion
        }

        [Fact]
        public void DadaContaPreExistente_QuantoAdicionaContaIgual_EntaoLancaExcecao()
        {
            #region Arrange
            var agencia = 1100;
            var quantidadeDeContas = 5;
            #endregion

            #region Act
            var gerenciador = CriarNovoGerenciadorDeContas(agencia, quantidadeDeContas);
            #endregion

            #region Assert
            Assert.Throws<Exception>(() => gerenciador.AbrirConta(agencia, 1));
            #endregion
        }
    }
}
