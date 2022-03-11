using System.Diagnostics.CodeAnalysis;

namespace StudentBankAccount
{
    [ExcludeFromCodeCoverage]
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
    }
}
