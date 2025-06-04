using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04.Models
{
    public class ReservaHotel
    {
        public static List<ReservaHotel> reservasValidas = new();
        public string NomeHospede { get; set; }
        public int Dias { get; set; }
        public decimal ValorDiaria { get; set; }

        public decimal ValorTotal()
        {
            return ValorDiaria * Dias;
        }

        public bool Validar(ReservaHotel r)
        {
            if (Dias <= 0 || ValorDiaria <= 0) return false;
            reservasValidas.Add(r);
            return true;
        }

        public string ResumoReserva()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Hospede = {NomeHospede}");
            sb.AppendLine($"Quantidade de dias = {Dias}");
            sb.AppendLine($"Valor da diária: {ValorDiaria:C}");
            sb.AppendLine($"Valor total: {ValorTotal():C}");

            return sb.ToString();
        }
    }
}