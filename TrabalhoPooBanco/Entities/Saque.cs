namespace TrabalhoPooBanco.Entities;
public class Saque : Transacao
{
    public Cliente Cliente { get; private set; }

    public Saque(Cliente cliente, decimal valor) : base(valor)
    {
        Cliente = cliente;
    }

    public override Resultado Executar()
    {
        return Cliente.Conta.Sacar(Valor);
    }
}