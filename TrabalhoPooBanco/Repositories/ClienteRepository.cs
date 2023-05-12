using TrabalhoPooBanco.Entities;

namespace TrabalhoPooBanco.Repositories;

public class ClienteRepository
{
    private static List<Cliente> Clientes = new List<Cliente>();

    public void Salvar(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public List<Cliente> Listar()
    {
        return Clientes;
    }

    public void Atualizar(Cliente cliente)
    {
        var indice = Clientes.IndexOf(cliente);
        Clientes[indice] = cliente;
    }

    public Cliente ObterClientePeloNumeroConta(string numeroConta)
    {
        return Clientes.Where(cliente => cliente.Conta.Numero == numeroConta).FirstOrDefault();
    }
}
