using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A51LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imagine uma lista de frutas
            List<string> frutas = new List<string>
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };
            //Vamos imprimir essa lista
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
            Console.WriteLine();

            ///image1
            ///<image url="$(ProjectDir)\Slides\image1.png" scale=""/>
            //Adicionar um elemento ao final de uma lista é rápido

            //Porém inserir no meio da lista exige mais esforço computacional

            ///image2
            ///<image url="$(ProjectDir)\Slides\image2.png" scale=""/>
            //porque os elementos têm que ser deslocados para darem
            //espaço ao novo elemento!
            //E se tivermos que remover esse elemento, os elementos
            //seguintes precisam ser deslocados de novo!

            //Quanto maior a lista, mais ineficiente é a inserção
            //e remoção de elementos no meio dela!
            //Que coleção é apropriada para inserção/remoção rápida?

            //Apresentando LISTA LIGADA (LINKED LIST):
            //- Elementos não precisam estar em sequência em memória
            //- Cada elemento sabe quem é o anterior e o próximo
            //- Cada elemento é um "nó" que contém um valor

            ///linked
            ///<image url="$(ProjectDir)\Slides\linked.png" scale=""/>
            //Como a ordem é mantida? Usando ponteiros
            ///linked2
            ///<image url="$(ProjectDir)\Slides\linked2.png" scale=""/>
            //Instanciando uma nova lista ligada: dias da semana
            LinkedList<string> dias = new LinkedList<string>();
            //Adicionando um dia qualquer: "quarta"
            var d4 = dias.AddFirst("quarta");
            //"quarta" é o primeiro elemento da lista ligada
            ///image3
            ///<image url="$(ProjectDir)\Slides\image3.png" scale=""/>
            //cada elemento é um nó: LinkedListNode<T>
            ///System.Collections.Generic.LinkedListNode`1[System.String]

            //Mas e o valor "quarta"? Está na propriedade d4.Value
            Console.WriteLine("d4.Value: " + d4.Value);
            //E para adicionar mais itens? LinkedList não possui Add!
            //Podemos adicionar de 4 formas:
            //1. Como primeiró nó
            //2. Como último nó
            //3. Antes de um nó conhecido
            //4. Depois de um nó conhecido

            //Vamos adicionar segunda, antes de quarta:
            var d2 = dias.AddBefore(d4, "segunda");
            ///image4
            ///<image url="$(ProjectDir)\Slides\image4.png" scale=""/>
            //Agora d2 e d4 estão ligados!
            //- d2.Next é igual a d4
            //- d4.Previous é igual a d2
            //Continuando com nossa lista ligada, 
            //vamos adicionar terça depois de segunda
            var d3 = dias.AddAfter(d2, "terça");
            ///image5
            ///<image url="$(ProjectDir)\Slides\image5.png" scale=""/>
            //Perceba que os "ponteiros", ou referências
            //de d2 e d4 foram redirecionados para d3!!
            //Vamos adicionar sexta depois de quarta
            var d6 = dias.AddAfter(d4, "sexta");
            ///image6
            ///<image url="$(ProjectDir)\Slides\image6.png" scale=""/>
            //sábado depois de sexta
            var d7 =dias.AddAfter(d6, "sábado");
            ///image7
            ///<image url="$(ProjectDir)\Slides\image7.png" scale=""/>
            //quinta antes de sexta
            var d5 = dias.AddBefore(d6, "quinta");
            ///image8
            ///<image url="$(ProjectDir)\Slides\image8.png" scale=""/>
            //domingo antes de segunda
            var d1 = dias.AddBefore(d2, "domingo");
            ///image9
            ///<image url="$(ProjectDir)\Slides\image9.png" scale=""/>
            //Agora vamos imprimir a lista ligada
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
            Console.WriteLine();

            //LinkedList NÃO DÁ suporte ao acesso de índice: dias[0]
            //por isso podemos fazer um laço foreach mas não um for!
            var quarta = dias.Find("quarta");
            
            //Para removermos um elemento, podemos tanto
            //remover pelo valor quanto pela 
            //referência do LinkedListNode
            //dias.Remove("quarta") ou dias.Remove(d4);
            dias.Remove("quarta");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
        }
    }

}
