using System;
using System.Runtime.InteropServices;
using Exercicio_05.Models;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            LojaOnline loja = new();
            for (int i = 1; i < 3; i++)
            {
                ItemCompra item = new();
                Console.Clear();
                Console.WriteLine($"Adicione o produto {i}:");
                Console.Write("Digite o nome do produto: ");
                item.NomeProduto = Console.ReadLine();

                Console.Write("Digite a quantidade: ");
                item.Quantidade = IsValidInt(Console.ReadLine());

                Console.Write("Digite o Preço unitário: R$ ");
                item.PrecoUnitario = IsValidDecimal(Console.ReadLine());

                loja.AdicionarItem(item);
            }

            Console.Clear();
            Console.WriteLine("Sua lista de compras foi: ");
            Console.WriteLine(loja.ListarItens());
            Console.WriteLine($"O total da compra foi: {loja.TotalCarrinho().ToString("C")}");
            
        }
        
        static decimal IsValidDecimal(string i)
        {
            bool sucess = decimal.TryParse(i, out decimal number);

            while (!sucess || number <= 0)
            {
                Console.Write("Digite um valor válido: ");
                sucess = decimal.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }

        static int IsValidInt(string i)
        {
            bool sucess = int.TryParse(i, out int number);

            while (!sucess || number <= 0)
            {
                Console.Write("Digite um valor válido: ");
                sucess = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}