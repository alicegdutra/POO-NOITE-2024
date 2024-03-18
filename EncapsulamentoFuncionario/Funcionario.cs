using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        
    }
}