using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //os elementos que entrarão no array
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            ////inicializando um array populado
            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            ////inicializando um array populado (SINTAXE SIMPLIFICADA)
            //string[] aulas = 
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //declarando um array vazio de tamanho 3
            string[] aulas = new string[3];
            //preenchendo posições no array pelo índice
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            //A linha abaixo não imprime os elementos!
            Console.WriteLine(aulas); //System.String[]

            Imprimir(aulas);

            Console.WriteLine();

            //Pegando o primeiro elemento
            Console.WriteLine(aulas[0]);
            //Pegando o último elemento
            Console.WriteLine(aulas[aulas.Length - 1]);

            //Modificando um elemento do array: ASSIM NÃO FUNCIONA!
            aulaIntro = "Trabalhando com Arrays";
            Imprimir(aulas);

            //Modificando um elemento do array: DESSE JEITO FUNCIONA!
            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            Console.WriteLine();

            //Localizando a primeira ocorrência no array
            Console.WriteLine("Aula 'modelando' está no índice " + Array.IndexOf(aulas, aulaModelando));
            //Localizando a última ocorrência no array
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            //Revertendo a sequência do array
            Array.Reverse(aulas);
            Imprimir(aulas);

            //Revertendo NOVAMENTE a sequência do array
            Array.Reverse(aulas);
            Imprimir(aulas);

            //Redimensionando um array (truncando a última posição)
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            //Redimensionando um array (deixando a última posição vazia)
            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            //Preenchendo a última posição do Array
            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            //Ordenando o Array pela ordem natural dos elementos (alfabética)
            Array.Sort(aulas);
            Imprimir(aulas);

            //Copiando um Array em outro
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            //Clonando um Array em um novo Array (note o cast as string[])
            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            //Limpando alguns índices do Array
            Array.Clear(clone, 1, 2);
            Imprimir(clone);
        }

        private static void Imprimir(string[] aulas)
        {
            Console.WriteLine();

            ////Enumerando um array (laço FOREACH é mais simples)
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //Enumerando um array (laço FOR permite mais controle!)
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
