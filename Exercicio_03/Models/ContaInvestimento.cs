using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03.Models
{
    public class ContaInvestimento
    {
        private decimal _redimento;
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        public decimal TaxaJuros { get; set; }

        public void Depositar(decimal valor)
        {
            if (valor < 0) throw new InvalidOperationException($"Com {valor:C} não é possível fazer operação do tipo depósito");

            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor < 0) throw new InvalidOperationException($"Com {valor:C} não é possível fazer operação do tipo Sacar");
            if (valor > Saldo) throw new InvalidOperationException($"Com {valor:C} não é possível fazer operação do tipo Sacar, pois é superior ao seu saldo {Saldo:C}");

            Saldo -= valor;
        }

        public decimal CalcularRedinmento(int meses)
        {
            _redimento = Saldo * TaxaJuros * meses;
            return _redimento;
        }

        public string ExibirResumo()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Titular da Conta = {Titular}");
            sb.AppendLine($"Taxa de Juros = {TaxaJuros:P}");
            sb.AppendLine($"Saldo da Conta = {Saldo:C}");
            sb.AppendLine($"Rendimento esperado para 12 meses = {CalcularRedinmento(12):C}");

            return sb.ToString();
        }
    }
}