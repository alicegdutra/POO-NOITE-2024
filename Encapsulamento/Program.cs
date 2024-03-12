using Encapsulamento;

Conta c1 = new Conta();
/*PADRÃO C# PARA ENCAPSULAMENTO - ALTERAÇÃO DE CONTEÚDO */
c1.Numero = 1000; //set
Console.WriteLine("Numero" = c1.Numero()); //get


/*c1.AlterarNumero(1000); EXEMPLO 1
Console.WriteLine("Numero" = c1.BuscarNumero()); */

/*c1.SetNumero(1000); EXEMPLO 2
Console.WriteLine("Numero" = c1.GetNumero()); */

