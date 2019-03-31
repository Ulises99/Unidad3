using System;
using System.Collections.Generic;
using System.Text;

namespace Operaciones
{
    public class Multiplicacion
    {
        private double m1, m2, resultado;

        public Multiplicacion()
        {
            this.M1 = 0;
            this.M2 = 0;
        }

        public double Calculo()
        {
            resultado = M1 * M2;
            return resultado;
        }

        public double M1 { get => m1; set => m1 = value; }
        public double M2 { get => m2; set => m2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
    }
}
