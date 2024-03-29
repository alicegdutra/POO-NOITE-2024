﻿using ArrayProduto;
//declaração de vetor e cadastro/adicionar objetos no vetor
Produto[] vetP = new Produto[3];
for(int i = 0; i < vetP.Length; i++)
{
    //instanciar cada possição do vetor
    vetP[i] = new Produto();
    Console.Write("Digite o código: ");
    vetP[i].codigo= Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome: ");
    vetP[i].nome= Console.ReadLine();
    Console.Write("Digite o preço: ");
    vetP[i].preco= Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite a quantidade: ");
    vetP[i].quantidade= Convert.ToInt32(Console.ReadLine());
}
double soma = 0;
double total = vetP[i].ValorTotalEmEstoque();
for(int i = 0; i < vetP.Length; i++)
{
    vetP[i].MostrarAtributos();
    Console.WriteLine($"Total {vetP[i].ValorTotalEmEstoque():c}");
    Console.WriteLine($"Total {total:c}");
    soma = soma + total;
}
Console.WriteLine($"Valor total dos produtos {soma:c}");

foreach (Produto p in vetP)
{
    Console.Write("Digite a quantidade vendida:");
    int qtde = Convert.ToInt32(Console.ReadLine());
    p.RemoverEstoque(qtde);
    p.MostrarAtributos();
}