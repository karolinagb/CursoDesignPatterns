using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if(orcamento.Valor < 1000.0)
            {
                return orcamento.Valor * 0.5;
            }
            else if(orcamento.Valor >= 1000.0 && orcamento.Valor <= 3000.0)
            {
                return orcamento.Valor * 0.7;
            }
            else
            {
                return (orcamento.Valor * 0.8) + 30.0;
            }
        }
    }
}
