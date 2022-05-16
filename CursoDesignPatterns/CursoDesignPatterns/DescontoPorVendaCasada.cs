using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (vendaCasada(orcamento))
            {
                return orcamento.Valor * 0.08;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }

        private bool vendaCasada(Orcamento orcamento)
        {
            return existe("Caneta", orcamento) && existe("Lapis", orcamento);
        }

        private bool existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach(var item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
