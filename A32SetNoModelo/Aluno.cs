using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32SetNoModelo
{
    /// <summary>
    /// Representa um Aluno, com nome e número de matrícula
    /// </summary>
    class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        /// <summary>
        /// Obtém o texto com detalhes do aluno, no formato "[Nome: , Matrícula: ]"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula}]";
        }
    }
}
