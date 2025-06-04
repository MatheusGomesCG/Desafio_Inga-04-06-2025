using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Exercicio_05.Models
{
    public class LojaOnline
    {
        private decimal _totalValor;
        public List<ItemCompra> ItensCompra { get; set; } = new();

        public void AdicionarItem(ItemCompra i)
        {
            ItensCompra.Add(i);
        }

        public decimal TotalCarrinho()
        {
            _totalValor = ItensCompra.Sum(x => x.PrecoUnitario * x.Quantidade);
            return _totalValor;
        }

        public string ListarItens()
        {
            StringBuilder sb = new();
            foreach (var item in ItensCompra)
            {
                sb.AppendLine($"Item = {item.NomeProduto}");
                sb.AppendLine($"Quantidade = {item.Quantidade}");
                sb.AppendLine($"Valor Unitário = {item.PrecoUnitario:C}");
            }

            return sb.ToString();
        }
    }
}