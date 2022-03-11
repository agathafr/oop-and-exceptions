using System;
using Xunit;

namespace StudentBankAccount.Tests.GerenciadorDeContasTest
{
    public class EncerrarContaTest : GerenciadorDeContasBaseTest
    {
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
