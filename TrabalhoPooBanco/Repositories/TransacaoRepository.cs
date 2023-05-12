using TrabalhoPooBanco.Entities;

namespace TrabalhoPooBanco.Repositories;

public class TransacaoRepository
{
    private List<Transacao> Transacoes = new List<Transacao>();

    public void Salvar(Transacao transacao)
    {
        Transacoes.Add(transacao);
    }
}
