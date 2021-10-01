using System;

namespace meuPrimeirPrograma
{
    class Program
    {
        static void Main(string[] args)
        {

            var Mario = Employee.Create(
                name: "Mario",
                cpf: "123.123.123-45",
                role: "Vendedor",
                salary: 1000
            );

            var Kendrick = Employee.Create(
                name: "Kendrick",
                cpf: "123.123.123-45",
                role: "Vendedor",
                salary: 1000
            );

            Employee.LogAll();
            
            var niceAgency = new Agency(1234);

            var GabrielAccount = Account.Create("Gabriel F", niceAgency, 100, Mario);
            var TupacAccount = Account.Create("Tupac", niceAgency, 99000, Kendrick);
            var InjectionAccount = Account.Create("injection(x => death);", niceAgency, 150, Kendrick);

            Account.LogAll();

            GabrielAccount.Sacar(90);
            TupacAccount.Sacar(70);
            InjectionAccount.Sacar(110);

            Account.LogAll();

            GabrielAccount.Depositar(100);
            TupacAccount.Depositar(80);
            InjectionAccount.Depositar(50);

            Account.LogAll();

            GabrielAccount.Transferir(15, TupacAccount);
            TupacAccount.Transferir(20, InjectionAccount);
            InjectionAccount.Transferir(25, GabrielAccount);

            Account.LogAll();

            Console.WriteLine("\nProgram End\n");
        }
    }
}