﻿using AgregacaoConta;

Endereco end = new Endereco("Rua x", 75, "pp"); // o cliente no momento da classe a gente incluiu um atirbuto novo que é endereco , instancia o objeto e pode fazer a agregacao

Cliente cli = new Cliente("Ana", 1111, 111); // vai no atributo ender receber o end
cli.Ender = end; //agregando o endereco no cliente (cli)    CLI.ENDER - ATRIBUTO até aqui mas quando recebeu uma instancia de um objeto  END - OBJETO ele é objeto tbm

// tudo q ta do lado esquerdo é tipo, e tipo é classe
// 

Conta c1 = new Conta ();
c1.Numero = 1;
c1.Titular = cli; //agregando o cliente a conta c1 // objeto 
c1.Saldo=100;

Console.WriteLine("Numero da conta: " + c1.Numero);
Console.WriteLine("Saldo: " + c1.Saldo);
Console.WriteLine("Nome: " + c1.Titular.Nome);
Console.WriteLine("Rg: " + c1.Titular.Rg);
Console.WriteLine("Cpf: " + c1.Titular.Cpf);
Console.WriteLine("Endereco: " + c1.Titular.Ender.Logradouro);
Console.WriteLine("Numero: " + c1.Titular.Ender.Numero);
Console.WriteLine("Cidade: " + c1.Titular.Ender.Cidade);
