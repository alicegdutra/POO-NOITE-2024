// função main()
using ConstrutorConta;

Conta c1 = new Conta(); //construtor padrão
c1.MostrarAtributos();

Conta c2 = new Conta(235); //construtor padrão
c2.MostrarAtributos();

Conta c3 = new Conta(1,50); //construtor padrão
c3.MostrarAtributos();

Conta c4 = new Conta(50,1, "Alice"); //construtor padrão
c4.MostrarAtributos();
