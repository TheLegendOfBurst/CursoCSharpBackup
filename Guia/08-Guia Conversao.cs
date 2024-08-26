using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpBackup.Guia
{
    public class _8_Guia_Conversao
    {
        public static void DemonstrarConversoes()
        {
            // 1. Conversao Implicita
            int numInt = 100;
            long numLong = numInt;
            Console.Write($"Conversao implicita de int para long: {numLong}");

            // 2. Conversao Explicita
            double numDouble = 1234.56;
            int numCast = (int)numDouble;
            Console.Write($"Conversao explicita de double para int (cast): {numCast}");

            // 3. Conversao com Convert
            string numeroString = "456";
            int numConvert = Convert.ToInt32(numeroString);
            Console.WriteLine($"Conversao de string para int usando Convert: {numConvert}");

            // 4. Conversao com Parse
            string numeroString2 = "789";
            int numParse = int.Parse(numeroString2);
            Console.Write($"Conversao de string para int usando parse: {numParse}");

            // 5. Uso de TryParse para conversão segura 
            string numeroInvalido = "abc";
            bool conversaoSucesso  = int.TryParse(numeroInvalido, out int numTryParse);
            Console.WriteLine($"Conversao com TryParse (Sucesso): {conversaoSucesso}, valor: {numTryParse}");

            // 3. Conversao de Tipos Incompativeis
            object obj = 1234; // Boxing 
            int numUnboxed = (int)obj;
            Console.Write($"Unboxing de object para obj: {numUnboxed}");

            // 3. Conversao de Tipo numericos para string
            int numero = 42; // Boxing 
            string numString = numero.ToString() ;
            Console.Write($"Conversao de int para string: {numString}");
        }
    }
}
