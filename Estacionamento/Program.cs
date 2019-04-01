using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            Console.WriteLine("Fila criada");
            Console.WriteLine("Fila vazia? "+fila.Vazia);

            Carro a = new Carro("abc 1234");
            fila.Inserir(a);
            Console.WriteLine(a + " Inserido com sucesso na fila");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Estado atual da fila:\n" + fila.ToString());
            Console.ForegroundColor = ConsoleColor.White;

            Carro b = new Carro("bcd 2345");
            fila.Inserir(b);
            Console.WriteLine(b + " Inserido com sucesso na fila");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Estado atual da fila:\n" + fila.ToString());
            Console.ForegroundColor = ConsoleColor.White;

            Carro c = new Carro("cde 3456");
            fila.Inserir(c);
            Console.WriteLine(c + " Inserido com sucesso na fila");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Estado atual da fila:\n" + fila.ToString());
            Console.ForegroundColor = ConsoleColor.White;

            Carro d = new Carro("def 7891");
            fila.Inserir(d);
            Console.WriteLine(d + " Inserido com sucesso na fila");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Estado atual da fila:\n" + fila.ToString());
            Console.ForegroundColor = ConsoleColor.White;

            Carro e = new Carro("efg 2344");
            fila.Inserir(e);
            Console.WriteLine(e + " Inserido com sucesso na fila");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Estado atual da fila:\n" + fila.ToString());
            Console.ForegroundColor = ConsoleColor.White;

            fila.RetirarPorPlaca("def 7891");
            Console.WriteLine("Veículo de placa: def 7891, removido com sucesso");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Estado atual da fila:\n"+fila.ToString());
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            
        }
    }
}
