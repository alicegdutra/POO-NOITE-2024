﻿using AgrecacaoArrayConta;

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 100;
c1.VetTitulares = new List<Cliente>();

for (int i = 0; i < 3; i++)
{
    Cliente cli = new Cliente();
    System.Console.WriteLine("Nome: ");
    cli.Nome = Console.ReadLine();
    System.Console.WriteLine("RG: ");
    cli.Rg = Console.ReadLine();
    c1.VetTitulares.Add(cli);
}
c1.Mostrar();
foreach(Cliente c in c1.VetTitulares)
    c.Mostrar();

