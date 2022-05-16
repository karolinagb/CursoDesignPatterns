using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imposto iss = new ISS();
            //Imposto icms = new ICMS();
            //Imposto iccc = new ICCC();

            //Orcamento orcamento = new Orcamento(500.0);

            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            //calculador.RealizaCalculo(orcamento, icms);
            //calculador.RealizaCalculo(orcamento, iss);
            //calculador.RealizaCalculo(orcamento, iccc);

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lapis", 250));
            orcamento.AdicionaItem(new Item("Geladeira", 250));
            orcamento.AdicionaItem(new Item("Fogão", 250));
            orcamento.AdicionaItem(new Item("Microondas", 250));
            orcamento.AdicionaItem(new Item("XBOX", 250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
