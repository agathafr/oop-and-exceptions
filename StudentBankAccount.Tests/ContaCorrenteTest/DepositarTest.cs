using Xunit;

namespace StudentBankAccount.Tests.ContaCorrenteTest
{
    public class DepositarTest
    {
        [Fact]
        public void DadaContaPreExistente_QuandoRealizaDeposito_EntaoValorEhAdicionadoAConta()
        {
            #region Arrange - Act
            var conta = new ContaCorrente(1, 1);
            #endregion

            #region Act
            conta.Depositar(100);
            #endregion

            #region Assert
            Assert.Equal(200, conta.Saldo);
            #endregion
        }
    }
}
