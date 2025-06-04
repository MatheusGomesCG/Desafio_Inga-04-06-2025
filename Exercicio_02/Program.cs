using System;
using Exercicio_02.Models;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listaProduto = new();

            for (int i = 1; i <= 2; i++)
            {
                Produto p = new();
                Console.Clear();
                Console.WriteLine($"==== Cadastro do {i} produto ====");
                Console.Write("Digite o nome do produto: ");
                p.Nome = Console.ReadLine();

                Console.Write("Digite a categoria do produto: ");
                p.Categoria = Console.ReadLine();

                Console.Write("Digite o preço do produto: R$ ");
                p.PrecoBase = IsValidDecimal(Console.ReadLine());

                listaProduto.Add(p);
            }

            Console.Clear();
            foreach (var item in listaProduto)
            {
                Console.WriteLine("==== Produto sem desconto ====");
                Console.WriteLine(item);
                item.AplicarDesconto();
                Console.WriteLine("==== Produto com desconto ====");
                Console.WriteLine(item);
            }
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
    }
}