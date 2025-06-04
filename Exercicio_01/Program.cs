using System;
using System.Globalization;
using Exercicio_01.Models;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Aluno aluno = new();

            Console.Clear();
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            aluno.AdicionarNota(IsValidDouble(Console.ReadLine()));

            Console.Write("Digite a segunda nota: ");
            aluno.AdicionarNota(IsValidDouble(Console.ReadLine()));

            Console.Write("Digite a terceira nota: ");
            aluno.AdicionarNota(IsValidDouble(Console.ReadLine()));

            Console.Clear();
            Console.WriteLine(aluno);
        }

        static double IsValidDouble(string i)
        {
            bool sucess = double.TryParse(i, out double number);

            while (!sucess)
            {
                Console.Write("Digite um valor válido: ");
                sucess = double.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}