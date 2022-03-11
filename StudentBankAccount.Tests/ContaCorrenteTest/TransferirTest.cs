using System;
using Xunit;

namespace StudentBankAccount.Tests.ContaCorrenteTest
{
    public class TransferirTest
    {
        [Fact]
        public void DadaContaPreExistente_QuandoTentaRealizarTransferenciaMenorQue0_EntaoLancaArgumentException()
        {
            #region Arrange - Act
            var contaOrigem = new ContaCorrente(1, 1);
            var contaDestino = new ContaCorrente(1, 2);
            #endregion

            #region Act
            var exception = Assert.Throws<ArgumentException>(() => contaOrigem.Transferir(-10, contaDestino));
            #endregion

            #region Assert
            Assert.Contains("Valor inválido para a transferência.", exception.Message);
            #endregion
        }

        [Fact]
        public void DadaContaPreExistente_QuandoTentaRealizarTransferenciaMaiorQueSaldoDisponivel_EntaoAdicionaContadoresInternos()
        {
            #region Arrange - Act
            var contaOrigem = new ContaCorrente(1, 1);
            var contaDestino = new ContaCorrente(1, 2);
            #endregion

            #region Act
            var exception = Assert.Throws<OperacaoFinanceiraException>(() => contaOrigem.Transferir(5000, contaDestino));
            #endregion

            #region Assert
            Assert.Equal(1, contaOrigem.ContadorSaquesNaoPermitidos);
            Assert.Equal(1, contaOrigem.ContadorTransferenciasNaoPermitidas);
            #endregion
        }

        [Fact]
        public void DadaContaPreExistente_QuandoRealizaTransferencia_EntaoValidaTransacao()
        {
            #region Arrange - Act
            var contaOrigem = new ContaCorrente(1, 1);
            var contaDestino = new ContaCorrente(1, 2);
            #endregion

            #region Act
            contaOrigem.Transferir(10, contaDestino);
            #endregion

            #region Assert
            Assert.Equal(90, contaOrigem.Saldo);
            Assert.Equal(110, contaDestino.Saldo);
            #endregion
        }
    }
}
