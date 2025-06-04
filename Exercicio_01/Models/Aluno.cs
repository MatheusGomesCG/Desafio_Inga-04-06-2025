using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

namespace Exercicio_01.Models
{
    public class Aluno
    {
        private double _media;
        public string Nome { get; set; }
        public List<double> Notas { get; set; } = new();

        public void AdicionarNota(double n)
        {
            if (n < 0 || n > 10)
            {
                throw new Exception("Nota digitada é inconsistente!");
            }
            else
            {
                Notas.Add(n);
                Console.WriteLine("Nota foi adicionada com sucesso!");
            }
        }
        public void Media()
        {
            if (Notas.Count == 0)
            {
                throw new Exception("Não existe notas cadastradas no sistema");
            }
            else
            {
                foreach (var item in Notas)
                {
                    _media += item;
                }
                _media /= Notas.Count;
            }
        }
        public string Situacao()
        {
            StringBuilder sb = new StringBuilder();

            if (_media >= 7)
                sb.AppendLine("Aprovado");
            else if (_media >= 5)
                sb.AppendLine("Recuperação");
            else
                sb.AppendLine("Reprovado");

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Media();
            sb.AppendLine($"Nome = {Nome}");
            int count = 1;
            foreach (var item in Notas)
            {
                sb.AppendLine($"{count} Nota = {item.ToString("F1", CultureInfo.InvariantCulture)}");
                count++;
            }
            sb.AppendLine($"Media = {_media.ToString("F1", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Situação = {Situacao()}");

            return sb.ToString();
        }
    }
}