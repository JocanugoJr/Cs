using System;

namespace doKurso
{
    class Program
    {
        static bool minimus(int a, int b)
        {
            if(a>24 || a<0)
            {
                return true;
            }
            if(b>24 || b<0)
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os Valores de entrada:");
            string[] vet;
            int a, b;

            do
            {
                vet = Console.ReadLine().Split(' ');
                a = int.Parse(vet[0]);
                b = int.Parse(vet[1]);

            } while (minimus(a,b)==true);
                
            int horas = 24;
            int minuto;



            if (a < b)
            {
                horas = b - a;
            }
            else if(a>b)
            {
                horas = (horas - a) - b; 
            }

            minuto = horas * 60;
            Console.WriteLine("O JOGO DUROU " + horas + " HORAS OU " + minuto + " MINUTOS.");
        }
    }
}
