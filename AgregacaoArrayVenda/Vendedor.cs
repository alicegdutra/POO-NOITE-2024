using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArrayVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }
    }

    public void MostrarAtributos()
    {
        Console.WriteLine("Comissão: " + Comissao);
    }
}
