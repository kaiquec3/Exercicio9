using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_9
{
    class Numero
    {
        double valor;

        public void SetValor(double p)
        {
            valor = p;
        }

        public double GetValor()
        {
            return valor;
        }

        public int Comparar(double p)
        {
            int k;
            if (valor > p)
            {
                k = 1;
                return k;
            }
            else if (valor < p)
            {
                k = -1;
                return k;
            }
            else
            {
                k = 0;
                return k;
            }

        }
    }
}
