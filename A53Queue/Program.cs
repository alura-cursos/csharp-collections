using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A53Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {

            //entrou: van               
            Enfileirar("van");
            ///<image url="$(ProjectDir)\Slides\queue1.png" scale=""/>
            //entrou: kombi
            Enfileirar("kombi");
            ///<image url="$(ProjectDir)\Slides\queue2.png" scale=""/>
            //entrou: guincho
            Enfileirar("guincho");
            ///<image url="$(ProjectDir)\Slides\queue3.png" scale=""/>
            //entrou: pickup
            Enfileirar("pickup");
            ///<image url="$(ProjectDir)\Slides\queue4.png" scale=""/>

            //carro liberado
            Desenfileirar();
            ///<image url="$(ProjectDir)\Slides\queue5.png" scale=""/>
            //carro liberado
            Desenfileirar();
            ///<image url="$(ProjectDir)\Slides\queue6.png" scale=""/>
            //carro liberado
            Desenfileirar();
            ///<image url="$(ProjectDir)\Slides\queue7.png" scale=""/>
            ///carro liberado
            Desenfileirar();
            //carro liberado
            Desenfileirar();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("guincho está fazendo o pagamento.");
                }

                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine();
            Console.WriteLine("FILA:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
