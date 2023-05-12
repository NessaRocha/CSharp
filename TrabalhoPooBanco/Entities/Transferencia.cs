namespace TrabalhoPooBanco.Entities;

public class Transferencia : Transacao
{
    public Cliente De { get; private set; }
    public Cliente Para { get; private set; }

    public Transferencia(Cliente de, Cliente para, decimal valor) : base(valor)
    {
        De = de;
        Para = para;
    }

    public override Resultado Executar()
    {
        return De.Conta.Transferir(Valor, Para.Conta);
    }
}