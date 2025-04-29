using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrd
{
    internal class Program
    {
        //METODO ORDENACAO BUBBLESORT
        static void bubblesort(int[] array, int n)
        {
            for (int i = (n - 1); i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        //se o vetor na posicao j for maior do que o numero no vetor na frente dele, eles trocam de lugar
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        //METODO SELECTIONSORT
        static void selectionsort(int[] array, int n)
        {
            for (int i = 0; i < (n - 1); i++)
            {
                int menor = i;
                for (int j = (i + 1); j < n; j++)
                {
                    //compara os elemnetos em pares, do 1 ate o ultimo e troca se o elemento da frente for menor que o "menor"
                    if (array[menor] > array[j])
                    {
                        menor = j;
                    }
                }
                int temp = array[i];
                array[i] = array[menor];
                array[menor] = temp;
            }
        }

        //METODO INSERTIONSORT
        static void insertsort(int[] array, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int tmp = array[i];
                int j = i - 1;

                //pega a partir do segundo elemento e compara se e menor com o primeiro, e depois vai "pegando" cada elemento e comparando com os elemnetos anteriores a esse elemento
                while ((j >= 0) && (array[j] > tmp))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = tmp;
            }
        }

        //METODO DE ORDENACAO QUICKSORT (UNICO METODO COM RECURSIVIDADE QUE VOU FAZER)
        static void quicksort(int[] v, int esquerda, int direita)
        {
            int part;
            //Condicao de parada
            if (esquerda < direita)
            {
                part = particao(v, esquerda, direita);
                //Nas 2 chamadas modifica o esquerda ou o direita diminuindo o incio e o direita
                quicksort(v, esquerda, part - 1);
                quicksort(v, part + 1, direita);
            }
        }

        //Escolhe o pivo (sempre o ultimo elemento da parte é o pivot), Reduz a lista em duas partes uma com elementos menores que o pivô (a esquerda) e outra elementos maiores que o pivô ( a direita), retorna a part em que o pivot vai ficar
        static int particao(int[] v, int esquerda, int direita)
        {
            int n = 0;
            int pivot = v[direita];
            int part = esquerda - 1;    
            for (int i = esquerda; i <= direita - 1; i++)
            {
                if (v[i] < pivot)
                {
                    part = part + 1;
                    troca(v, part, i);
                }
            }
            part++;
            troca(v, part, direita);
            return part;
        }
        
        //Realiza a troca de numeros entre o pivot e o da direita
        static void troca(int[] v, int part, int i)
        {
            int temp = v[part];
            v[part] = v[i];
            v[i] = temp;
        }

        static void Main(string[] args)
        {
            int[] q = { 4, 1, 12, 3, 234343,28438, 2, 45, 22};
            quicksort(q, 0, q.Length - 1);
            Console.WriteLine("Quick: ");
            for (int i = 0; i <= q.Length - 1; i++)
            {
                Console.Write(q[i] + " ");
            }

            //bubble
            int[] b = { 4, 1, 12, 3, 234343, 28438, 2, 45, 22 };
            bubblesort(b, b.Length);
            Console.WriteLine("\nBublle: ");
            for (int i = 0; i <= b.Length - 1; i++)
            {
                Console.Write( b[i] + " ");
            }

            //selection
            int[] s = { 4, 1, 12, 3, 234343, 28438, 2, 45, 22 };
            selectionsort(s, s.Length);
            Console.WriteLine("\nSelection: ");
            for (int i = 0; i <= s.Length - 1; i++)
            {
                Console.Write(s[i] + " ");
            }

            //insertion
            int[] ins = { 4, 1, 12, 3, 234343, 28438, 2, 45, 22 };
            insertsort(ins, ins.Length);
            Console.WriteLine("\nInsert: ");
            for (int i = 0; i <= ins.Length - 1; i++)
            {
                Console.Write(ins[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
