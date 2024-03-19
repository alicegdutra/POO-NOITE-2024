using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo { get; set; } 

        public string Nome { get; set; }      

        public double Preco { get; set; }

        public int Corredor { get; set; }

        public static int Contador { get; set; }

        public Produto()
        {
            Contador ++;
        }

         public Produto(int codigo)
        {
            Codigo =  codigo;
            Contador ++;
        }

         public Produto(int codigo, double preco)
        {
            Codigo =  codigo;
            Preco = preco;
            Contador ++;
    
        }

        public Produto(int codigo, double preco, string nome)
        {
            Codigo =  codigo;
            Preco = preco;
            Nome = nome;
            Contador ++;
        }

        public Produto(int codigo, double preco, string nome, int corredor)
        {
            Codigo =  codigo;
            Preco = preco;
            Nome = nome;
            Corredor = corredor;
            Contador ++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + Codigo + "\tPreço: " + Preco + "\tNome: " + Nome + "\tCorredor: " + Corredor);
        }
        
    }
}