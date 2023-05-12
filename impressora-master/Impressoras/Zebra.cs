
using Etiquetagem.Modelos;

namespace Etiquetagem.Impressoras;

public class Zebra : IImpressoraDeCodigoDeBarras
{
    private readonly int _resolucao;
    private readonly string _tamanhoEtiqueta;
    private readonly string _tipoEtiqueta;

    public Zebra()
    {
        _resolucao = 600;
        _tamanhoEtiqueta = "15cm x 7cm";
        _tipoEtiqueta = "Poliéster";
    }

    public bool ImprimirEtiqueta(Produto produto)
    {
        // Implementação da impressão de etiqueta na impressora Zebra
        Console.WriteLine($"Imprimindo etiqueta do produto {produto.Id} na impressora Zebra...");
        Console.WriteLine($"Código de barras: {produto.CodigoBarras}");
        Console.WriteLine($"Preço: R$ {produto.Preco}");
        Console.WriteLine($"Resolução: {_resolucao}dpi");
        Console.WriteLine($"Tamanho da etiqueta: {_tamanhoEtiqueta}");
        Console.WriteLine($"Tipo de etiqueta: {_tipoEtiqueta}");
        Console.WriteLine("Etiqueta impressa com sucesso!");
        return true;
    }
}
