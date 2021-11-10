public class Gerente : Funcionario {
    public int NumeroDeAgencias { get; set; }

    public override double Bonificacao { 
        get {
            return _bonificacao;
        }
        set {
            _bonificacao += value * 0.05;
        }
    }

    public override int CalcularFerias ()
    {
        var dias_ferias = 30 + NumeroDeAgencias * 5;
        return dias_ferias;
    }
}