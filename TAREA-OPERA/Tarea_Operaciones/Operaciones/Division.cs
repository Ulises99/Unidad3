using System;
using System.Collections.Generic;
using System.Text;

namespace Operaciones
{
    public class Division
    {
        private double d1, d2, resultado;

        public Division()
        {
            this.D1 = 0;
            this.D2 = 0;
        }

        public double Calculo()
        {
            resultado = D1 / D2;
            return resultado;
        }

        public double D1 { get => d1; set => d1 = value; }
        public double D2 { get => d2; set => d2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
    }
}
