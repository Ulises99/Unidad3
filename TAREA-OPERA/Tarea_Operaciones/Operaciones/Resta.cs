using System;
using System.Collections.Generic;
using System.Text;

namespace Operaciones
{
    public class Resta
    {
        private double r1,r2,resultado;

        public Resta()
        {
            this.R1 = 0;
            this.R2 = 0;
        }

        public double Calculo()
        {
            resultado = R1 - R2;
            return resultado;
        }

        public double R1 { get => r1; set => r1 = value; }
        public double R2 { get => r2; set => r2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
    }
}
