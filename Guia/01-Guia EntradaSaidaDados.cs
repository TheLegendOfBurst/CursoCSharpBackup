using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    public static class EntradaSaidaDados
    {
        public static void LerArmazenar()
        {
            string nome;
            bool nomeValido;

            do
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();

                // Verifica se a entrada está vazia
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("O nome não pode estar vazio. Por favor, digite novamente.");
                    nomeValido = false;
                }
                // Verifica se a entrada contém apenas números
                else if (int.TryParse(nome, out _))
                {
                    Console.WriteLine("O nome não pode ser um número. Por favor, digite novamente.");
                    nomeValido = false;
                }
                else
                {
                    nomeValido = true;
                }

            } while (!nomeValido);

            Console.WriteLine($"Seu Nome é: {nome}!");
        }
    }
}