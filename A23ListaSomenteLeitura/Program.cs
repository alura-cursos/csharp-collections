using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A23ListaSomenteLeitura
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
