using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A21Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //os elementos que entrarão na lista
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            ////inicializando uma lista populada
            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //declarando uma lista vazia
            List<string> aulas = new List<string>();
            //alimentando a lista com método Add
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            //Pegando o primeiro elemento (usando índice)
            Console.WriteLine("A primeira aula é " + aulas[0]);
            //Pegando o primeiro elemento (usando LINQ)
            Console.WriteLine("A primeira aula é " + aulas.First());

            //Pegando o último elemento (usando índice)
            Console.WriteLine("A última aula é " + aulas[aulas.Count - 1]);
            //Pegando o último elemento (usando LINQ)
            Console.WriteLine("A última aula é " + aulas.Last());

            //modificando elemento pelo índice
            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);

            //Obtendo primeiro elemento que atende uma condição
            //(usando LINQ e expressão lambda no predicate)
            Console.WriteLine("A primeira aula 'Trabalhando' é: "
                + aulas.First(aula => aula.Contains("Trabalhando")));

            //Obtendo último elemento que atende uma condição
            //(usando LINQ e expressão lambda no predicate)
            Console.WriteLine("A última aula 'Trabalhando' é: "
                + aulas.Last(aula => aula.Contains("Trabalhando")));

            ////Obtendo primeiro elemento que atende uma condição,
            ////mas nenhum elemento atende, logo obtemos uma exceção!
            //Console.WriteLine("A primeira aula 'Conclusão' é: "
            //    + aulas.First(aula => aula.Contains("Conclusão")));

            Console.WriteLine();

            //Obtendo o primeiro elemento que atende uma condição OU
            //um valor default (null) se não houver nenhum
            //(de forma segura e sem gerar exceção)
            Console.WriteLine("A primeira aula 'Conclusão' é: "
                + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            Console.WriteLine();

            //Revertendo a sequência da lista
            aulas.Reverse();
            Imprimir(aulas);

            //Revertendo NOVAMENTE a sequência da lista
            aulas.Reverse();
            Imprimir(aulas);

            //Removendo o último elemento (por índice)
            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            //Adicionando um elemento (ao final da lista)
            aulas.Add("Conclusão");
            Imprimir(aulas);

            //Ordenando a lista pela ordem natural dos elementos (alfabética)
            aulas.Sort();
            Imprimir(aulas);

            //Ordenando a lista através de um comparador custom,
            //por ordem de tamanho da string
            aulas.Sort((aula1, aula2) => aula1.Length.CompareTo(aula2.Length));
            Imprimir(aulas);

            //Copiando os 2 últimos elementos de uma lista para
            //uma nova lista
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            //Clonando a lista de aulas para uma outra lista 
            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            //Removendo os dois últimos elementos da lista, pelo índice
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);
        }

        private static void Imprimir(List<string> aulas)
        {
            Console.WriteLine();
            ////Enumerando uma lista (laço FOREACH é mais simples)
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //Enumerando uma lista (laço FOR permite mais controle!)
            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}

            //Método ForEach: 
            //Executa uma ação (Action) para cada elemento do array
            aulas.ForEach(aula => 
            {
                Console.WriteLine(aula);
            });
            Console.WriteLine();
        }
    }
}

