
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public static class TiposPrimitivos
    {
        public static void ImprimirTipos()
        {
            // Tipo inteiro de 8 bits com sinal
            sbyte SByte = -128;
            Console.WriteLine($"sbyte: {SByte}");

            // Tipo inteiro de 8 bits sem sinal
            byte variavelByte = 255;
            Console.WriteLine($"byte: {variavelByte}");

            // Tipo inteiro 16 bits com sinal
            short variavelShort = -32768; //valores variam de -32768 a 32767
            Console.WriteLine($"short: {variavelShort}");

            // Tipo inteiro de 16 bits sem sinal
            ushort variavelUshort = 65535;
            Console.WriteLine($"ushort: {variavelUshort}");

            // Tipo inteiro de 32 bits com sinal
            int variavelInt = -2147481648;
            Console.WriteLine($"int: {variavelInt}");

            // Tipo inteiro de 32 bits sem sinal
            uint variavelUInt = 4294967295;
            Console.WriteLine($"uint: {variavelUInt}");

            // Tipo inteiro de 64 bits com sinal
            long variavelLong = -9223372036854775808;
            Console.WriteLine($"long: {variavelLong}");

            // Tipo inteiro de 64 bits sem sinal
            ulong variavelULong = 18446744073709551615;
            Console.WriteLine($"ulong: {variavelULong}");

            // Tipo de ponto flutuante de 32 bits
            float variavelFloat = 3.14f;
            Console.WriteLine($"float: {variavelFloat}");

            // Tipo de ponto flutuante de 64 bits
            double variavelDouble = 3.141592653589793;
            Console.WriteLine($"double: {variavelDouble}");

            // Tipo decimal de 128 bits, usado para valores monetarios e financeiros
            decimal variavelDecimal = 7922816251426433759354395335M;
            Console.WriteLine($"decimal: {variavelDecimal}");

            // Tipo de caractere Unicode de 16 bits
            char variavelChar = 'A';
            Console.WriteLine($"char: {variavelChar}");

            // Tipo booleano que pode ser verdadeiro ou falso
            bool variavelBool = true;
            Console.WriteLine($"bool: {variavelBool}");

            // Tipo de valor Nulo
            object? variavelObject = null;
            Console.WriteLine($"object: {variavelObject}");

            // Tipo string, sequencia de caracteres Unicode
            string variavelString = "Buenas Tardes";
            Console.WriteLine($"string: {variavelString}");
        }
    }
}
