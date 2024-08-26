using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpBackup.Guia
{
    public class _7_Guia_OperadorTernario
    {
        public static void DemonstrarTernario()
        {
            int a = 10;
            int b = 20;


            int maior = (a > b) ? a : b;
            Console.Write($"O maior valor entre {a} e {b} é {maior} ");


            int numero = 15;
            string resultado = (numero % 2 == 0) ? "Par" : "Impar";
            Console.Write($"O numero {numero} é {resultado} ");


            string nome = "";
            string mensagem = (nome == "") ? "Nome vazio" : $"Nome: {nome}";
            string mensagem2 = (!string.IsNullOrEmpty(nome)) ? "Nome Valido" : "Nome Invalido";

            Console.WriteLine(mensagem);
            Console.WriteLine(mensagem2);
        }
    }
}
