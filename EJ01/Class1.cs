using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01
{
    static class Class1
    {
        public static  double calcularArea (this Triangulo triangulo )
        {
            return (triangulo.lados[0] * triangulo.altura) / 2;
        }
    }

}
