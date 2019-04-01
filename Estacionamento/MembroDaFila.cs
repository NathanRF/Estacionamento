using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class MembroDaFila
    {        
        public MembroDaFila prox;
        public Carro carro;
        public MembroDaFila(Carro carro)
        {
            this.carro = carro;
        }
    }
}
