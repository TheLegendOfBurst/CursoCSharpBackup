using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Guia
{
    public static class _3_Guia_OperadoresLogicos
    {
        public static bool ELogico(bool a, bool b)
        {
            return a && b;
        }

        public static bool OULogico(bool a, bool b)
        {
            return a || b;
        }

        public static bool Negacao(bool a)
        {
            return !a;
        }

        public static bool OUExclusivo(bool a, bool b)
        {
            return a ^ b;
        }
    }
}
