using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Conta
    {
        private int numero; //minúsculo - ATRIBUTO
        private string? titular;
        private double saldo;
    }
    public int Numero //maiúsculo - PROPRIEDADE
    {
        set{
            this.Numero = value; //alterar
            //recebe qualquer valor, é genérico
            //armazena/ altera no atributo NUMERO
            // THIS - nome de instância genérico, referência qualquer nome de variável
        }
        get {
            return this.Numero; //buscar
        }
    }
    //profull - encapsulamento (propriedade) compelto
    /*private string titular;*/
    public string Titular
    {
        get { return titular; } /* ou this.titular*/
        set { titular = value; }
    }

    /*private double saldo;*/
    public double Saldo
    {
        get { return saldo; }
        set { saldo = value; }
    }
    
    
    /*public void SetNumero(int numeroConta) //parametro para alteração EXEMPLO 1
    {
        numero = numeroConta;
        //sair um valor de uma função - retorno
        //estado do objeto - valor que a variável tem

    }
    public int GetNumero()
    {
        return numero;
    }
    public void AlterarNumero(int numeroConta) //parametro para alteração EXEMPLO 2
    {
       numero = numeroConta;
        //sair um valor de uma função - retorno
        //estado do objeto - valor que a variável tem

    }
    public int BuscarNumero()
    {
       return numero;
    //}*/
}