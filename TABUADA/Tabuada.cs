using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABUADA { 
    class Tabuada
    {
        public static List<int> CalcularTabuada(int numero)
        {
            List<int> tabuada = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                tabuada.Add(numero * i);
            }
            return tabuada;
        }
    }
}

