using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 4578420);
                ContaCorrente conta2 = new ContaCorrente(485, 456487);

                conta2.Transferir(10000, conta);

                conta.Depositar(50);
                Console.WriteLine("Saldo da conta: " + conta.Saldo);
                conta.Sacar(-500);
                Console.WriteLine("Saldo da conta após saque: " + conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException." );
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine("Saldo da conta no momento da exceção: " + ex.Saldo);
                Console.WriteLine("Valor do saque: " + ex.ValorSaque);

                Console.WriteLine(ex.StackTrace);
                
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Execução finalizada. Tecle enter para sair.");
            }

            Console.ReadLine();
        }

        
    }
}
