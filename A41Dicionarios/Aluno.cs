using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A41Dicionarios
{
    /// <summary>
    /// Representa um Aluno, com nome e número de matrícula
    /// </summary>
    public class Aluno
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
        }

        private int numeroMatricula;
        public int NumeroMatricula
        {
            get { return numeroMatricula; }
        }

        public Aluno(String nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        /// <summary>
        /// Obtém o texto com detalhes do aluno, no formato "[Nome: , Matrícula: ]"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[Aluno: " + this.nome + ", matricula: " + this.numeroMatricula + "]";
        }

        /// <summary>
        /// Determina se esta instância de aluno e outra instância de aluno 
        /// possuem o mesmo valor.
        /// </summary>
        /// <param name="obj">A outra instância de Aluno a ser comparada</param>
        /// <returns>Verdadeiro ou falso, indicando se as duas instâncias possuem o mesmo valor.</returns>
        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
            {
                return false;
            }

            return this.nome.Equals(outro.nome);
        }

        ///<image url="$(ProjectDir)\Slides\image1.png" scale=""/>

        /// <summary>
        /// Retorna o código de dispersão para este Aluno.
        /// </summary>
        /// <returns>Um código de dispersão inteiro de 32 bits.</returns>
        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }

        //IMPORTANTE!!
        //Dois objetos que são iguais possuem o mesmo hash code.
        //PORÉM, o contrário não é verdadeiro: 
        //Dois objetos com mesmo hash codes não são necessariamente iguais! 

        ///<image url="$(ProjectDir)\Slides\image2.png" scale=""/>
    }
}
