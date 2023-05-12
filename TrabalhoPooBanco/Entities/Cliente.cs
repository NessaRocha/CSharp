namespace TrabalhoPooBanco.Entities;

public class Cliente : Pessoa
{
    public ContaCorrente Conta { get; private set; }
    public Cliente(string nome, string cpf, ESexo sexo, ContaCorrente conta) :
        base(nome, cpf, sexo)
    {
        Conta = conta;
    }

    public override void MostrarDados()
    {
        base.MostrarDados();
        Conta.MostrarDados();
    }

}