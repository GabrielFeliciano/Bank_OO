using System;
using System.Collections.Generic;

public class Employee {

    static public List<Employee> allEmployee = new List<Employee>();
    static public double totalComission { get; private set; }
    static public double comissionFator { get; private set; } = 0.01;

    static public void LogAll () {
        Console.WriteLine("\nRegistered Employees:\n");
        foreach (var empl in allEmployee) {
            Console.WriteLine($"Name: {empl.Name}, Comission: {empl.Comission}, Salary: {empl.Salary}");
        }
        Console.WriteLine("\nEnd\n");
    }


    static public Employee Create (string name, string cpf, string role, double salary) {
        var empl = new Employee(name, cpf, role, salary);

        allEmployee.Add(empl);

        return empl;
    }

    private Employee (
        string name, string cpf, string role, double salary
    ) {
        Name = name;
        CPF = cpf;
        Role = role;
        Salary = salary;
        Comission = 0;
    }
    
    public string Name { get; private set; }
    public string CPF { get; private set; }
    public string Role { get; private set; }
    public double Salary { get; private set; }
    public double Comission { get; private set; } // idk

    public void SetComission (double balance) {
        double value = balance * comissionFator;
        Comission = value;
        totalComission += value;
    }

}