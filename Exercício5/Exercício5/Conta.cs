using System;
using System.Globalization;

namespace Exercício5
{
    class Conta
    {

        //Private
        private const double _taxa = 5.00;//taxa para o saque
        
        //Publics e Properties
        public int Num {//o número da conta, o usuário não pode mudar, apenas vê-lo
            get;
            private set;//para dizer que o número nunca poderá ser mudado.
        }
        public string Nome//se o usuário quiser editar, ele consegue
        {
            get; 
            set;
        }
        public double Saldo 
        { 
            get; 
            private set; 
        }

        //Construtores
        public Conta(int num, string nome)
        {
            Num = num;
            Nome = nome;
        }
        public Conta(int num, string nome, double depositoInic): this(num, nome)
        {
            Aumenta(depositoInic);//o ideal não é atribuir, o ideal é somar ao saldo.
        }

        //Métodos
        public void Aumenta(double deposito)//o saldo só aumenta por depósito
        {
            Saldo += deposito;
        }
        public void Sacar(double saque)//pode ficar com saldo negativo.
        {
            Saldo -= (_taxa + saque);
        }

        public override string ToString()
        {
            return "Conta "+Num
                +", Titular: "+Nome
                +", Saldo: $ "+Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
