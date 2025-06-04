using System;
using Exercicio_04.Models;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                ReservaHotel reserva = new();
                Console.WriteLine("==== CADASTRO DE RESERVA HOTEL ====");
                Console.WriteLine("[1] - CRIAR RESERVA HOTEL");
                Console.WriteLine("[2] - EXIBIR RESERVAS VALIDAS");
                Console.WriteLine("[3] - SAIR");
                string opcao = Console.ReadLine();

                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("==== CRIAR RESERVA ====");
                        Console.Write("Digite o nome do hospede: ");
                        reserva.NomeHospede = Console.ReadLine();

                        Console.Write("Digite a quantidade de dias: ");
                        reserva.Dias = IsValidInt(Console.ReadLine());

                        Console.Write("Digite o valor da diária: ");
                        reserva.ValorDiaria = IsValidDecimal(Console.ReadLine());

                        Console.Clear();
                        if (reserva.Validar(reserva)) Console.WriteLine(reserva.ResumoReserva());
                        else Console.WriteLine("Reserva inválida!!!");
                        VoltarMenu();
                        break;
                    case "2":
                        Console.WriteLine("==== RESERVAS VÁLIDAS =====");
                        foreach (var item in ReservaHotel.reservasValidas)
                        {
                            Console.WriteLine(item.ResumoReserva());   
                        }
                        VoltarMenu();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida !!!");
                        VoltarMenu();
                        break;
                }
            }
            
            Console.WriteLine("Obrigado por usar o programa!!!!");
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