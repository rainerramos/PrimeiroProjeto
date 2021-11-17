using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais2");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18 || quantidadePessoas >= 2)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }


            Console.ReadLine();
        }
    }
}

