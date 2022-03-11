using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace StudentBankAccount
{
    [ExcludeFromCodeCoverage]
    public class LeitorDeArquivo : IDisposable
    {
        private string[] _linhas;

        public LeitorDeArquivo(string arquivo)
        {
            _linhas = File.ReadAllLines(arquivo);
        }

        public GerenciadorDeContas ObterContas()
        {
            var gerenciador = new GerenciadorDeContas();
            foreach (var dados in _linhas)
            {
                var conta = dados.Split(',');
                var agencia = Convert.ToInt32(conta[0]);
                var numero = Convert.ToInt32(conta[1]);
                gerenciador.AbrirConta(agencia, numero);
            }
            return gerenciador;
        }

        public void Dispose()
        {
            _linhas = null;
            GC.SuppressFinalize(this);
        }

    }
}
