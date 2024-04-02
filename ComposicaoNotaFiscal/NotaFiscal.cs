using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
            public int NumeroNf { get; set; }

            public string Data { get; set; }

            public List<ItemNotaFiscal> VetItens {get; set;}

            public NotaFiscal (int nf, string data)
            {
                NumeroNf = nf;
                Data = data;
                VetItens = new List<ItemNotaFiscal>();
              //COMPOSIÇÃO
            }
            public void AdicionarItens(ItemNotaFiscal itens)
            {
                VetItens.Add(itens); // método para adicionar
            }
    }
}