using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgrecacaoArrayConta
{
    public class Conta
    {
    
        public int Numero { get; set;}

        public List<Cliente> VetTitulares {get; set;}
        public double Saldo {get; set;}

        public void Mostrar()
        {
            System.Console.WriteLine("Número: " + Numero + "Saldo: " + Saldo);
        }


    }
}