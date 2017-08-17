using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A23ListaSomenteLeitura
{
    /// <summary>
    /// Representa uma aula, com Titulo e Tempo
    /// </summary>
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

        /// <summary>
        /// Obtém texto para impressão de detalhes da aula
        /// </summary>
        /// <returns>Texto com detalhes da aula</returns>
        public override string ToString()
        {
            return $"[título: {titulo}, tempo: {tempo} minutos]";
        }
    }
}
