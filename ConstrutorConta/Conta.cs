using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; } 

        public string Titular { get; set; }      

        public double Saldo { get; set; }

        public bool Situacao { get; set; }

        public Conta()
        {
            
        }

         public Conta(int numero)
        {
            
        }

        public Conta(int numero, double saldo, string titular)
        {
            Numero =  numero;
            Titular = titular;
            Saldo = saldo;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + Numero +
            "\tTitular: " + Titular + "\tSaldo: " + Saldo);
        }
        
    }
}