using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBarbara = new ContaCorrente();

            contaDaBarbara.titular = "Barbara";
            contaDaBarbara.agencia = 1234;
            contaDaBarbara.conta = 789;
            contaDaBarbara.saldo = 100.50;

            ContaCorrente contaDoJoao = new ContaCorrente();

            contaDoJoao.titular = "Joao";
            contaDoJoao.agencia = 1234;
            contaDoJoao.conta = 790; 
            contaDoJoao.saldo = 120;

            Console.WriteLine("O titular da conta é: " + contaDaBarbara.titular);
            Console.WriteLine("O titular da conta é: " + contaDoJoao.titular);
        }
    }
}
