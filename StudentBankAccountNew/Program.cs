using System;
using System.Diagnostics.CodeAnalysis;

namespace StudentBankAccount
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main()
        {
            try
            {
                var gerenciador = CarregarContas("../../../contas.txt");
                foreach(var conta in gerenciador.Contas) 
                {
                    Console.WriteLine(conta);
                }
                Console.WriteLine($"\nContas Criadas: {gerenciador.TotalDeContasCriadas}");
                Console.WriteLine($"Taxa de Operação Atual: R$ {gerenciador.TaxaOperacao.ToString("N2")}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao carregar contas {ex.Message}.");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair.");
            Console.ReadLine();
        }

        private static GerenciadorDeContas CarregarContas(string nomeArquivo)
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo(nomeArquivo))
            {
                return leitor.ObterContas();
            }
        }
    }
}
