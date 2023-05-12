using System;

using Etiquetagem.Impressoras;


namespace Etiquetagem.Modelos
{
    class Program
    {
        static void Main(string[] args)
        {
            var elgin = new Elgin();
            var zebra = new Zebra();

            var impressoras = new List<IImpressoraDeCodigoDeBarras> { elgin, zebra };

            Console.WriteLine("Informe o código de barras do produto:");
            var codigoBarras = Console.ReadLine();

            var produto = new Produto
            {
                Id = 1,
                CodigoBarras = codigoBarras,
                Preco = (double)10.99m
            };

            foreach (var impressora in impressoras)
            {
                var impressao = impressora.ImprimirEtiqueta(produto);
                if (impressao)
                {
                    Console.WriteLine($"Etiqueta impressa com sucesso na impressora {impressora.GetType().Name}");
                }
                else
                {
                    Console.WriteLine($"Erro na impressão da etiqueta na impressora {impressora.GetType().Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
