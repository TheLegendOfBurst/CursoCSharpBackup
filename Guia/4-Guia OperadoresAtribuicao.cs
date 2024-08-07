using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpBackup.Guia
{
    public class _4_Guia_OperadoresAtribuicao
    {
        public static void AtribuicaoSimples() 
        {
            int a = 10;
            Console.WriteLine($"Valor de a apos atribuição: {a}"); // Imprime: Valor de a: 10
        }

        public static void AtribuicaoSoma()
        {
            int a = 10;
            a += 5;
            Console.WriteLine($"Valor de a apos atribuição +=: {a}"); // Imprime: Valor de a: 10
        }

        public static void AtribuicaoSubtracao()
        {
            int a = 10;
            a -= 5;
            Console.WriteLine($"Valor de a apos atribuição -=: {a}"); // Imprime: Valor de a: 10
        }

        public static void AtribuicaoMultiplicacao() 
        {
            int a = 10;
            a *= 5;
            Console.WriteLine($"Valor de a apos atribuição *=: {a}"); // Imprime: Valor de a: 10
        }

        public static void AtribuicaoDivisao()
        {
            int a = 10;
            a /= 5;
            Console.WriteLine($"Valor de a apos atribuição /=: {a}"); // Imprime: Valor de a: 10
        }

        public static void AtribuicaoModulo()
        {
            int a = 10;
            a %= 5;
            Console.WriteLine($"Valor de a apos atribuição %=: {a}"); // Imprime: Valor de a: 10
        }

        public static void AtribuicaoAnd()
        {
            int a = 12; // Binario: 1100
            a &= 7; // Binario: 0111
                    // Resultado: 0100 ( 4 em decimal )
            Console.WriteLine($"Valor de a apos atribuição &=: {a}"); // Imprime: Valor de a: 10
        }

        public static void AtribuicaoOr()
        {
            int a = 12; // Binario: 1100
            a &= 5; // Binario: 0101
                    // Resultado: 1101 ( 13 em decimal )
            Console.WriteLine($"Valor de a apos atribuição &=: {a}"); // Imprime: Valor de a: 10
        }

        public static void AtribuicaoXor()
        {
            int a = 12; // Binario: 1100
            a ^= 7; // Binario: 0110
                   // Resultado: 1010 ( 10 em decimal )
            Console.WriteLine($"Valor de a apos atribuição ^=: {a}"); // Imprime: Valor de a: 10
        }

        public static void AtribuicaoDeslocamentoEsquerda()
        {
            int a = 4; // Binario: 0100
            a <<= 2; // Desloca 2 bits a esquerda? 0001 0000 ( 16 em decimal)
            Console.WriteLine($"Valor de a apos atribuição <<= 2: {a}"); // Imprime: Valor de a: 10
        }

        public static void AtribuicaoDeslocamentoDireita()
        {
            int a = 4; // Binario: 0001 0000
            a >>= 2; // Desloca 2 bits a esquerda? 0000 0100 ( 16 em decimal)
            Console.WriteLine($"Valor de a apos atribuição >>= 2: {a}"); // Imprime: Valor de a: 10
        }
    }
}
