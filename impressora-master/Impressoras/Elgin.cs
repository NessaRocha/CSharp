
using Etiquetagem.Modelos;


namespace Etiquetagem.Impressoras
{
    public class Elgin : IImpressoraDeCodigoDeBarras
    {
        private readonly int _resolucao;
        private readonly string _tamanhoEtiqueta;
        private readonly string _tipoEtiqueta;

        public Elgin()
        {
            _resolucao = 300;
            _tamanhoEtiqueta = "10cm x 5cm";
            _tipoEtiqueta = "Papel adesivo";
        }

        public bool ImprimirEtiqueta(Produto produto)
        {
            // Implementação da impressão de etiqueta na impressora Elgin
            Console.WriteLine($"Imprimindo etiqueta do produto {produto.Id} na impressora Elgin...");
            Console.WriteLine($"Código de barras: {produto.CodigoBarras}");
            Console.WriteLine($"Preço: R$ {produto.Preco}");
            Console.WriteLine($"Resolução: {_resolucao}dpi");
            Console.WriteLine($"Tamanho da etiqueta: {_tamanhoEtiqueta}");
            Console.WriteLine($"Tipo de etiqueta: {_tipoEtiqueta}");
            Console.WriteLine("Etiqueta impressa com sucesso!");
            return true;
        }
    }
}
