using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //os elementos que entrarão na lista
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 16);

            //declarando uma lista vazia
            List<Aula> aulas = new List<Aula>();
            //alimentando a lista com método Add
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            
            ////Você não pode adicionar uma string se a lista é de Aula!
            //aulas.Add("Conclusão");

            Imprimir(aulas);

            Console.WriteLine();
            //Ordenando a lista pela ordem natural dos elementos
            //(que não existe, a menos que Aula implemente IComparable!)
            aulas.Sort();
            Imprimir(aulas);

            //Ordenando a lista por uma ordem específica (por tempo)
            //passando um Comparison como argumento
            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);
        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.WriteLine();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }

    class Aula : IComparable //O IComparable é necessário para usarmos o método Sort!
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj) //O CompareTo é necessário para usarmos o método Sort!
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.titulo);
        }

        public override string ToString()
        {
            return $"[título: {titulo}, tempo: {tempo} minutos]";
        }
    }
}

