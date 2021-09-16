using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBarbara = new ContaCorrente("Barbara", 1234, 789, 100.50);
            ContaCorrente contaDoJoao = new ContaCorrente("Joao", 1234, 790, 120);
            ContaCorrente contaDaMaria = new ContaCorrente("Maria", 1234, 791, 150);

            contaDaBarbara.Sacar(50);
            Console.WriteLine("O saldo da conta da Barbara é: " + contaDaBarbara.Saldo);
        }
    }
}