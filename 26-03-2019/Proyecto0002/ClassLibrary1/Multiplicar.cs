using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Multiplicar
    {
        private double m1, m2, resultado;

        public Multiplicar()
        {
            this.M1 = 0;
            this.M2 = 0;
        }

        public double M1 { get => m1; set => m1 = value; }
        public double M2 { get => m2; set => m2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }

        public double CalMulti()
        {
            Resultado = M1 * M2;
            return Resultado;
        }
    }
}
