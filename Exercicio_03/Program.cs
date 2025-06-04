using System;
using Exercicio_03.Models;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaInvestimento c = new();

            Console.Write("Digite o nome do titular: ");
            c.Titular = Console.ReadLine();

            Console.Write("Digite o Saldo da conta: R$ ");
            c.Saldo = IsValidDecimal(Console.ReadLine());

            Console.Write("Digite a taxa de juros %: Ex: 1 ");
            decimal taxadeJuros = IsValidDecimal(Console.ReadLine());
            c.TaxaJuros = taxadeJuros/100;

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("==== MENU DE INTERAÇÃO COM A CONTA ====");
                Console.WriteLine("[1] - DEPOSITAR");
                Console.WriteLine("[2] - SACAR");
                Console.WriteLine("[3] - CALCULAR RENDIMENTO");
                Console.WriteLine("[4] - EXIBIR RESUMO");
                Console.WriteLine("[5] - SAIR");
                string opcao = Console.ReadLine();

                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("==== DEPOSITAR ====");
                        Console.Write("Digite o valor do seu deposito: R$ ");
                        c.Depositar(IsValidDecimal(Console.ReadLine()));

                        Console.Clear();
                        Console.WriteLine("Depósito realizado com sucesso!");
                        VoltarMenu();                        
                        break;
                    case "2":
                        Console.WriteLine("==== SACAR ====");
                        Console.Write("Digite o valor do seu saque: R$ ");
                        c.Sacar(IsValidDecimal(Console.ReadLine()));

                        Console.Clear();
                        Console.WriteLine("Saque realizado com sucesso!");
                        VoltarMenu(); 
                        break;
                    case "3":
                        Console.WriteLine("==== CALCULAR RENDIMENTO ====");
                        Console.Write("Digite a quantidade de meses que deseja calcular: ");
                        Console.WriteLine($"Sua conta vai render: {c.CalcularRedinmento(IsValidInt(Console.ReadLine())):C}");
                        VoltarMenu(); 
                        break;
                    case "4":
                        Console.WriteLine("==== RESUMO DA CONTA ====");
                        Console.WriteLine(c.ExibirResumo());
                        VoltarMenu();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida !!!");
                        VoltarMenu();
                        break;
                }
            }

            Console.WriteLine("Obrigado por usar nosso sistema!");
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

        static void VoltarMenu()
        {
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
        }
    }
}