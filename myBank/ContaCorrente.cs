public class ContaCorrente{
    
    public string titular; 
    public int agencia;
    public int conta; 
    private double saldo {get; set;}

    public ContaCorrente() {}

    public ContaCorrente(string contacorrente_titular, int contacorrente_agencia, int contacorrente_conta, double contacorrente_saldo)
    { 
        titular = contacorrente_titular;
        agencia = contacorrente_agencia;
        conta = contacorrente_conta;
        saldo = contacorrente_saldo;
    }

    public bool Sacar (double valor){
        if(this.saldo < valor){
            return false;
        }
        else{
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar (double valor){
        this.saldo += valor;
    }

    public bool Transferir (double valor, ContaCorrente contaDestino){
        if (this.saldo < valor){
            return false;
        }
        else{
            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }


}