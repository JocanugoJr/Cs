using System;
using System.Globalization;

namespace Exercício5
{
    class Program
    {
        static void imprime(Conta pessoa)
        {
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(pessoa);
            Console.WriteLine();
        }
        static void Main()
        {
            Conta pessoa;

            Console.WriteLine("Entre com os dados da conta:");
            Console.Write("Número da Conta: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Nome do Titular: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Deseja fazer um depósito inicial? (s/n)");
            char resposta;

            do
            {
                resposta = char.Parse(Console.ReadLine());//como se lê um char
                if (resposta == 's')
                {
                    Console.Write("Insira o valor de depósito inicial: ");
                    double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoa = new Conta(num, nome, deposito);
                }
                else
                {
                    pessoa = new Conta(num, nome);
                }
            } while (resposta != 's' && resposta != 'n');

            imprime(pessoa);

            while (true)
            {
                Console.WriteLine("Deseja:");
                Console.WriteLine("1-Depositar;");
                Console.WriteLine("2-Sacar;");
                Console.WriteLine("3-Sair");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("Entre com um valor para depósito: ");
                    double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoa.Aumenta(deposito);
                }
                else if(option == 2)
                {
                    Console.Write("Entre com um valor para saque: ");
                    double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoa.Sacar(saque);
                }
                else
                {
                    break;
                }

                imprime(pessoa);
            }

            imprime(pessoa);
        }
    }
}
