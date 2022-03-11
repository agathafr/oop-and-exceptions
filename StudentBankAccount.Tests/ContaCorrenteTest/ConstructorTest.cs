using System;
using Xunit;

namespace StudentBankAccount.Tests.ContaCorrenteTest
{
    public class ConstructorTest
    {
        [Theory]
        [InlineData(0, 10, "O argumento agência deve ser maior que zero.")]
        [InlineData(10, 0, "O argumento número deve ser maior que zero.")]
        public void DadosParametrosInvalidos_QuandoTentaInstanciarClasse_EntaoLancaArgumentException(int agencia, int numero, string mensagemErro)
        {
            #region Arrange - Act
            var exception = Assert.Throws<ArgumentException>(() => new ContaCorrente(agencia, numero));
            #endregion

            #region Assert
            Assert.Contains(mensagemErro, exception.Message);
            #endregion
        }
    }
}
