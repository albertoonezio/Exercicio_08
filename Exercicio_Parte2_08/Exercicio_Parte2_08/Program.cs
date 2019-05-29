using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDigitado = string.Empty;

            Console.Write("Digite um nome: ");
            nomeDigitado = Console.ReadLine();

            if (nomeDigitado == "Alberto")
            {
                Console.WriteLine("NOME CORRETO");
            }

            else
            {
                Console.WriteLine("NOME INCORRETO");
            }
        }
    }
}
