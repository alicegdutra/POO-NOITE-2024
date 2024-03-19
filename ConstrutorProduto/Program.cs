using ConstrutorProduto;

Produto p1 = new Produto(); //construtor padrão
p1.MostrarAtributos();

Produto p2 = new Produto(123); //construtor padrão
p2.MostrarAtributos();

Produto p3 = new Produto(15, 20); //construtor padrão
p3.MostrarAtributos();

Produto p4 = new Produto(69, 16, "Arroz"); //construtor padrão
p4.MostrarAtributos();

Produto p5 = new Produto(528, 25, "Café", 12); //construtor padrão
p5.MostrarAtributos();

Console.WriteLine("Quantidade de instâncias: " + Produto.Contador);