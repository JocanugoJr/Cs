using System;

namespace doKurso
{
    class Program
    {
        //public static decimal Abs(decimal value);
        static bool Multiplus(int a, int b)
        {
            if (Math.Abs(a) > Math.Abs(b))
            {
                if (a % b == 0)
                {
                    return true;
                }
            }
            else
            {
                if (b % a == 0)
                {
                    return true;
                }
            }

            return false;
        }
        static void Main()
        {
            Console.WriteLine("Informe os Valores de entrada:");
            
            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (Multiplus(a, b) == true)
            {
                Console.WriteLine("São Múltiplos");
            }
            else
            {
                Console.WriteLine("Não são Múltiplos");
            }

        }

        //
    }
}
