using System;
using System.Collections.Generic;

public class Account {

    public string name { get; private set; }
    public Agency agency { get; private set; }
    public double balance { get; private set; }

    // Global
    static public readonly List<Account> Accounts = new List<Account>();

    static public void LogAll () {
        Console.WriteLine("\nRegistered Accounts:\n");
        foreach (var account in Accounts) {
            Console.WriteLine($"Name: {account.name}, Balance: {account.balance}, Agency: {account.agency}");
        }
        Console.WriteLine("\nEnd\n");
    }

    public static Account Create (
        string name, 
        Agency agency, 
        double balance,
        Employee employee
    ) {
        employee.SetComission(balance: balance);

        Account account = new Account(
            name: name, 
            agency: agency,  
            balance: balance
        );

        Accounts.Add(account);

        Console.WriteLine(account.name);

        return account;
    }

    private Account(
        string name, 
        Agency agency,
        double balance
    ) {
        this.name = name;
        this.agency = agency;
        this.balance = balance;
    }

    public bool Sacar (double valor){
        if(this.balance < valor){
            return false;
        }
        else{
            this.balance -= valor;
            return true;
        }
    }

    public void Depositar (double valor){
        this.balance += valor;
    }

    public bool Transferir (double valor, Account contaDestino){
        if (this.balance < valor){
            return false;
        }
        else{
            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }
}