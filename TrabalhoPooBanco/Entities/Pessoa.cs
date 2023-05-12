namespace TrabalhoPooBanco.Entities;

public abstract class Pessoa
{
    public string Nome { get; protected set; }
    public string CPF { get; protected set; }
    public ESexo Sexo { get; protected set; }

    public Pessoa(string nome, string cpf, ESexo sexo)
    {
        Nome = nome;
        CPF = cpf;
        Sexo = sexo;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cpf: {CPF}");
        Console.WriteLine($"Sexo: {Sexo.ToString()}");
    }
}

public enum ESexo
{
    Masculino = 1,
    Feminino = 2,
}