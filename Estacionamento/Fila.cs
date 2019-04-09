using System.Text;

namespace Estacionamento
{
    class Fila
    {
        MembroDaFila first, last;

        public Fila()
        {
            this.first = new MembroDaFila(null);
            this.last = this.first;
        }

        public bool Vazia
        {
            get { return (this.first == this.last); }
        }

        public void Inserir(Carro carro)
        {
            MembroDaFila novo = new MembroDaFila(carro);
            this.last.prox = novo;
            this.last = novo;
        }

        public Carro RetirarDoTopo()
        {
            if (this.Vazia)
                return null;
            MembroDaFila auxiliar = this.first.prox;
            this.first.prox = auxiliar.prox;
            if (auxiliar == this.last)
                this.last = this.first;
            else
                auxiliar.prox = null;
            
            return auxiliar.carro;
        }

        public Carro RetirarPorPlaca(string placa)
        {
            if (Vazia)
                return null;
            else
            {
                Carro auxiliar;

                do
                {
                    auxiliar = RetirarDoTopo();
                    if (auxiliar.placa.Equals(placa))
                        return auxiliar;
                    else
                        Inserir(auxiliar);
                }
                while (!auxiliar.placa.Equals(placa) && auxiliar != null);

                return null; //Não encontrado
            }            
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            MembroDaFila membro = first.prox;
            int contador = 1;

            while (membro != null)
            {
                result.Append(contador+": "+membro.carro.ToString()+"\n");
                contador++;
                membro = membro.prox;
            }
            return result.ToString();
        }
    }
}
