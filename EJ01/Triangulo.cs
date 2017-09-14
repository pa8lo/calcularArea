using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01
{
    class Triangulo : FiguraGeometrica
    {
        public List<double> lados = new List<double>();
         public double altura;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cateto1">Base del triangulo</param>
        /// <param name="cateto2"></param>
        /// <param name="hipotenuza"></param>
        /// <param name="altura"></param>
        public Triangulo(double cateto1, double cateto2, double hipotenuza, double altura)
        {
            lados.Add(cateto1);
            lados.Add(cateto2);
            lados.Add(hipotenuza);
            this.altura = altura;
        }
      

        public double CalcularPerimetro()
        {
            double resultado = 0;
            foreach (var lado in lados)
            {
                resultado += lado;
            }
            return resultado;
        }
    }
}
