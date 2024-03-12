using Encapsulamento;

Conta c1 = new Conta();
/*PADRÃO C# PARA ENCAPSULAMENTO - ALTERAÇÃO DE CONTEÚDO */
c1.Numero = 1000; //set
Console.WriteLine("Numero" = c1.Numero()); //get
c1.Titular = "Fatec"; //set
Console.WriteLine("Titular" = c1.Titular()); //get
c1.Saldo = 1050; //set
Console.WriteLine("Saldo" = c1.Saldo());//get


/*c1.AlterarNumero(1000); EXEMPLO 1
Console.WriteLine("Numero" = c1.BuscarNumero()); */

/*c1.SetNumero(1000); EXEMPLO 2
Console.WriteLine("Numero" = c1.GetNumero()); */

