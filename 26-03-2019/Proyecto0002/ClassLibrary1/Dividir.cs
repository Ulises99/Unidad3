using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dividir
    {
        private double d1, d2, resultado;

        public Dividir()
        {
            this.D1 = 0;
            this.D2 = 0;
        }

        public double D1 { get => d1; set => d1 = value; }
        public double D2 { get => d2; set => d2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }

        public double CalDiv()
        {
            Resultado = D1 / D2;
            return Resultado;
        }
    }
}
