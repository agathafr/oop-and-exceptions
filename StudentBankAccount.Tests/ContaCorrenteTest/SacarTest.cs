using System;
using Xunit;

namespace StudentBankAccount.Tests.ContaCorrenteTest
{
    public class SacarTest
    {
        [Fact]
        public void DadaAberturaDeConta_QuandoInstanciaClasse_EntaoSaldoInicialIgualA100()
        {
            #region Arrange - Act
            var conta = new ContaCorrente(1, 1);
            #endregion

            #region Assert
            Assert.Equal(100, conta.Saldo);
            #endregion
        }

        [Fact]
        public void DadaContaPreExistente_QuandoTentaRealizarSaqueMenorQue0_EntaoLancaArgumentException()
        {
            #region Arrange - Act
            var conta = new ContaCorrente(1, 1);
            #endregion

            #region Act
            var exception = Assert.Throws<ArgumentException>(() => conta.Sacar(-10));
            #endregion

            #region Assert
            Assert.Contains("Valor inválido para o saque.", exception.Message);
            #endregion
        }

        [Fact]
        public void DadaContaPreExistente_QuandoTentaRealizarSaqueMaiorQueSaldo_EntaoAdicionaContadorDeSaquesNaoPermitidos()
        {
            #region Arrange - Act
            var conta = new ContaCorrente(1, 1);
            #endregion

            #region Act
            var exception = Assert.Throws<SaldoInsuficienteException>(() => conta.Sacar(5000));
            #endregion

            #region Assert
            Assert.Equal(1, conta.ContadorSaquesNaoPermitidos);
            #endregion
        }
    }
}
