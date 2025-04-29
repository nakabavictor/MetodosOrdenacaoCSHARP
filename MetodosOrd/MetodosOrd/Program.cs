using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOrd
{
    internal class Program
    {
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
            int[] v = { 4, 1, 12, 3, 234343,28438, 2, 45, 22};
            quicksort(v, 0, v.Length - 1);

            for (int i = 0; i <= v.Length - 1; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
