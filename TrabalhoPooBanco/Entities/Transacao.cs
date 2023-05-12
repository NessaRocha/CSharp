namespace TrabalhoPooBanco.Entities;

public abstract class Transacao
{
    public decimal Valor { get; protected set; }

    public Transacao(decimal valor)
    {
        Valor = valor;
    }

    public abstract Resultado Executar();
}