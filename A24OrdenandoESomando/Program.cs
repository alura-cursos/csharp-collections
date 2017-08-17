using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A24OrdenandoESomando
{
    class Program
    {
        static void Main(string[] args)
        {
            //desta vez criamos um curso para conter a coleção de aulas
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            //O método Adiciona encapsula a adição de novas aulas
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            Imprimir(csharpColecoes.Aulas);

            //adicionando 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));

            //imprimir
            Imprimir(csharpColecoes.Aulas);

            //IList não dá suporte ao método Sort!
            //csharpColecoes.Aulas.Sort();

            //copiando a lista para outra lista
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            //ordenando a cópia
            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            //imprimindo o tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);

            //imprimir detalhes do curso
            Console.WriteLine(csharpColecoes);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.WriteLine();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
