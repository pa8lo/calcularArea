using System;
using System.Collections.Generic;

namespace EJ01
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaGeometrica = new List<Triangulo>();
            
            Cuadrado cuadrado = new Cuadrado(4.8);
            Console.WriteLine("Perimero del cuadrado:" + cuadrado.CalcularPerimetro());
            Console.WriteLine("Area del cuadrado:" + cuadrado.CalcularArea());

            Circulo circulo = new Circulo(6.7);
            Console.WriteLine("Perimero del circulo:" + circulo.CalcularPerimetro());
            Console.WriteLine("Area del circulo:" + circulo.CalcularArea());

            Triangulo triangulo = new Triangulo(6, 7, 10, 10);
            Console.WriteLine("Perimero del triangulo:" + triangulo.CalcularPerimetro());
            Console.WriteLine("Area del triangulo:" + triangulo.CalcularArea());
            Console.Read();
            listaGeometrica.Add(triangulo);
            listaGeometrica.Add(new Triangulo(72, 8, 9, 9));
            listaGeometrica.Add(new Triangulo(75, 5, 8, 5));
            listaGeometrica.Add(new Triangulo(79, 6, 7, 5));
            listaGeometrica.Add(new Triangulo(70, 7, 4, 2));
            listaGeometrica.Add(new Triangulo(77, 3, 5, 3));
            listaGeometrica.Add(new Triangulo(78, 9, 15, 8));

        }
    }
}
