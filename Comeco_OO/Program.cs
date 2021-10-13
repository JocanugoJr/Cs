using System;
using System.Globalization;

namespace Comeco_OO
{
    class Program
    {
        static double Parte_p(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return p;
        }
        static double Formula_deHeron(double a, double b, double c)
        {
            double area, p;
            p = Parte_p(a, b, c);
            area = Math.Sqrt(p*((p-a)*(p-b)*(p-c)));
            return area;
        }
        static void Main()
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double trianguloX = Formula_deHeron(x.A, x.B, x.C);

            Console.WriteLine("Entre com as medidas do Triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double trianguloY = Formula_deHeron(y.A, y.B, y.C);

            Console.WriteLine("X: "+trianguloX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Y: " + trianguloY.ToString("F4", CultureInfo.InvariantCulture));
                
            if(trianguloX>trianguloY)
            {
                Console.WriteLine("O Triângulo X possui a maior área, medindo: "+trianguloX.ToString("F4", CultureInfo.InvariantCulture)+"m²");
            }
            else if(trianguloX==trianguloY)
            {
                Console.WriteLine("Areas iguais");
            }
            else
            {
                Console.WriteLine("O Triângulo Y possui a maior área, medindo: " + trianguloY.ToString("F4", CultureInfo.InvariantCulture)+"m²");
            }
        }
    }
}
