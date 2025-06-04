using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Exercicio_02.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal PrecoBase { get; set; }
        public string Categoria { get; set; }

        public void AplicarDesconto()
        {
            if (Categoria.ToUpper() == "ELETRÔNICO")
            {
                PrecoBase *= 0.85M;
            }
            else if (Categoria.ToUpper() == "VESTUÁRIO")
            {
                PrecoBase *= 0.9M;
            }
            else
            {
                PrecoBase *= 0.95M;
            }
        }

        public decimal PrecoFinal()
        {
            return PrecoBase;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome = {Nome}");
            sb.AppendLine($"Preço Final = {PrecoFinal():C}");

            return sb.ToString();
        }
    }
}