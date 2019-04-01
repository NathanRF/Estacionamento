using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Carro
    {
        public string placa;
        public Carro(string placa)
        {
            this.placa = placa;
        }

        public override string ToString()
        {
            return ("Placa do Veículo: " + this.placa);
        }
    }
}
