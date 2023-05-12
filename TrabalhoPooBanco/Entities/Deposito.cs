namespace TrabalhoPooBanco.Entities;

public class Deposito : Transacao
{
    public Cliente Cliente { get; private set; }

    public Deposito(Cliente cliente, decimal valor) : base(valor)
    {
        Cliente = cliente;
    }

    public override Resultado Executar()
    {
        return Cliente.Conta.Depositar(Valor);
    }
}
