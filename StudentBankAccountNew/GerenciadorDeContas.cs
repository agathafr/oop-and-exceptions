using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentBankAccount
{
    public class GerenciadorDeContas
    {
        private List<ContaCorrente> _contas;

        public int TotalDeContasCriadas
        {
            get { return _contas.Count; }
        }

        public double TaxaOperacao
        {
            get { return 30 / _contas.Count; }
        }

        public List<ContaCorrente> Contas 
        {
            get { return _contas; } 
        }

        public GerenciadorDeContas()
        {
            _contas = new List<ContaCorrente>();
        }

        public void AbrirConta(int agencia, int numero)
        {
            var contaPreExistente = _contas.FirstOrDefault(x => x.Numero == numero && x.Agencia == agencia);
            if (contaPreExistente != null)
            {
                throw new Exception($"Já foi cadastrada uma conta com o número {numero}");
            }

            _contas.Add(new ContaCorrente(agencia, numero));
        }

        public void EncerrarConta(int agencia, int numero)
        {
            var contaParaEncerrar = _contas.FirstOrDefault(x => x.Numero == numero && x.Agencia == agencia);
            if (contaParaEncerrar == null)
            {
                throw new Exception($"Não foi possível encontrar nenhuma conta, Agencia: {agencia}, Numero: {numero}.");
            }

            _contas.Remove(contaParaEncerrar);
        }
    }
}
