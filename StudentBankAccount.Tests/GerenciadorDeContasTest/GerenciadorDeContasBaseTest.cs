namespace StudentBankAccount.Tests.GerenciadorDeContasTest
{
    public class GerenciadorDeContasBaseTest
    {
        protected static GerenciadorDeContas CriarNovoGerenciadorDeContas(int agencia, int quantidadeDeContas)
        {
            var gerenciador = new GerenciadorDeContas();
            for (int i = 0; i < quantidadeDeContas; i++)
            {
                var numero = i + 1;
                gerenciador.AbrirConta(agencia, numero);
            }
            return gerenciador;
        }
    }
}
