using System;

namespace Operaciones
{
    public class Suma
    {
        private double s1, s2, resultado;

        public Suma()
        {
            this.S1 = 0;
            this.S2 = 0;
        }

        public double Calculo()
        {
            resultado = S1 + S2;
            return resultado;
        }

        public double S1 { get => s1; set => s1 = value; }
        public double S2 { get => s2; set => s2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
    }
}
