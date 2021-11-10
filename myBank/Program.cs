using System;

namespace bank_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteGaybriel = new Gerente(){
                Nome = "Gaybriel",
                CPF = "123.123.123-23",
                Salario = 2000,
                NumeroDeAgencias = 5
            };

            gerenteGaybriel.Bonificacao = gerenteGaybriel.Salario;

            Vendedor vendedorFodao = new Vendedor(){
                Nome = "Mr fodao",
                CPF = "456.456.456-56",
                Salario = 10000,
                NumeroClientesAtendidos = 2
            };

            vendedorFodao.Bonificacao = vendedorFodao.Salario;

            Vendedor vendedorTrollador = new Vendedor(){
                Nome = "Trollador",
                CPF = "696.969.696-96",
                Salario = 6900,
                NumeroClientesAtendidos = 4
            };

            vendedorTrollador.Bonificacao = vendedorTrollador.Salario;

            Vendedor vendedorJoseph = new Vendedor(){
                Nome = "Joseph",
                CPF = "789.789.789-89",
                Salario = 1000,
                NumeroClientesAtendidos = 3
            };

            vendedorJoseph.Bonificacao = vendedorJoseph.Salario;

            ContaCorrente contaDoChefao = new ContaCorrente("Gabriel Feliciano Pontes Morais", 1234, 200, vendedorJoseph); //Joseph
            ContaCorrente contaDaStefany = new ContaCorrente("Stefany", 1234, 6969, vendedorTrollador); //Maria
            ContaCorrente contaDoPedro = new ContaCorrente("Pedro", 1234, 1500, vendedorFodao); //Felipe

            Console.WriteLine(" ** **Contas ** **");

            Console.WriteLine("O titular da conta é: "+contaDoChefao.Titular);
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDoChefao.Saldo);
            Console.WriteLine("O vendedor responsável foi o: " + vendedorJoseph.Nome);
            
            Console.WriteLine("");

            Console.WriteLine("O titular da conta é: "+contaDaStefany.Titular);
            Console.WriteLine("O saldo da conta da Stefany é: " + contaDaStefany.Saldo);
            Console.WriteLine("O vendedor responsável foi a: " + vendedorTrollador.Nome);

            Console.WriteLine("");

            Console.WriteLine("O titular da conta é: "+contaDoPedro.Titular);
            Console.WriteLine("O saldo da conta do Pedro é: " + contaDoPedro.Saldo);
            Console.WriteLine("O vendedor responsável foi a: " + vendedorFodao.Nome);

            Console.WriteLine("");

            Console.WriteLine("Operações");
            Console.WriteLine("** Saque **");

            //Saque
            contaDoChefao.Sacar(20);
            Console.WriteLine("Operação de saque, num valor de R$ 20,00");
            Console.WriteLine("O saldo atual da conta da Bruna é: " + contaDoChefao.Saldo);
            Console.WriteLine("");
            Console.WriteLine("** Transferência **");
            
            //Trasferencia
            contaDoChefao.Transferir(10, contaDoPedro);
            Console.WriteLine("Operação de tranferência, num valor de R$ 10,00 - da Bruna para o Pedro.");
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDoChefao.Saldo);
            Console.WriteLine("O saldo da conta da Pedro é: " + contaDoPedro.Saldo);
            Console.WriteLine("");
            Console.WriteLine("** Depósito **");

            //Deposito
            contaDaStefany.Depositar(50);
            Console.WriteLine("Operação de Despósito, num valor de R$ 50,00");
            Console.WriteLine("O saldo da conta da Stefany é: " + contaDaStefany.Saldo);
            Console.WriteLine("");
            Console.WriteLine("** Saldo das Contas **");
            
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDoChefao.Saldo);
            Console.WriteLine("O saldo da conta da Stefany é: " + contaDaStefany.Saldo);
            Console.WriteLine("O saldo da conta do Pedro é: " + contaDoPedro.Saldo);
            Console.WriteLine("");
            Console.WriteLine("** Comissão vendedores **");

            Console.WriteLine("A comissao do vendedor Felipe é: " + vendedorFodao.Comissao);
            Console.WriteLine("A comissao da vendedora Maria é: " + vendedorTrollador.Comissao);
            Console.WriteLine("A comissao da vendedor Joseph é: " + vendedorJoseph.Comissao);
            Console.WriteLine("Total de comissão a ser pago: " + ContaCorrente.TotalDeComissao);
            Console.WriteLine("");
            Console.WriteLine("** Bonificação Anual **");

            Console.WriteLine("A bonificação do vendedor Felipe é de: R$" + vendedorFodao.Bonificacao);
            Console.WriteLine("A bonificação da vendedora Maria é de: R$" + vendedorTrollador.Bonificacao);
            Console.WriteLine("A bonificação do vendedor Joseph é de: R$" + vendedorJoseph.Bonificacao);
            Console.WriteLine("A bonificação da gerente Júlia é de: R$" + gerenteGaybriel.Bonificacao);
            Console.WriteLine("");
            Console.WriteLine("** Remuneração Total **");
            
            Console.WriteLine("O vendedor Felipe receberá R$" + vendedorFodao.RemuneracaoTotal(vendedorFodao.Salario, vendedorFodao.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("A vendedora Maria receberá R$" + vendedorTrollador.RemuneracaoTotal(vendedorTrollador.Salario, vendedorTrollador.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("O vendedor Joseph receberá R$" + vendedorJoseph.RemuneracaoTotal(vendedorJoseph.Salario, vendedorJoseph.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("A gerente Júlia receberá R$" + gerenteGaybriel.RemuneracaoTotal(gerenteGaybriel.Salario, gerenteGaybriel.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("");
            Console.WriteLine("** Férias **");

            Console.WriteLine("A gerente Júlia terá " + gerenteGaybriel.CalcularFerias() + " dias de férias");
            Console.WriteLine("O vendedor Felipe terá " + vendedorFodao.CalcularFerias() + " dias de férias");
            Console.WriteLine("A vendedora Maria terá " + vendedorTrollador.CalcularFerias() + " dias de férias");
            Console.WriteLine("O vendedor Joseph terá " + vendedorJoseph.CalcularFerias() + " dias de férias");
            Console.WriteLine("");
            Console.WriteLine("** Total de Contas **");

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);
        }
    }
}