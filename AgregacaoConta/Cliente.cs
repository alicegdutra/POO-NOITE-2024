using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string Nome {get; set;}
        public int Rg {get; set;}
        public int Cpf {get; set;}
        public Endereco Ender {get; set;}  //ATRIBUTO ATÉ AQUI
        public Cliente(string nome, int rg, int cpf)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
        }
    }
}