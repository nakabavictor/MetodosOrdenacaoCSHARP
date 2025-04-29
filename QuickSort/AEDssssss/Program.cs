using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDS
{
    internal class Program
    {
        static void quicksort(int[] v, int inicio, int fim)
        {
            int part;
            if (inicio < fim)
            {
                part = Particao(v, inicio, fim);
                quicksort(v, inicio, part - 1);
                quicksort(v, part + 1, fim);
            }
        }

        static int Particao(int[] v, int inicio, int fim)
        {
            int pivot = v[fim];
            int part = inicio - 1;
            for (int i = inicio; i <= fim - 1; i++)
            {
                if (v[i] < pivot)
                {
                    part = part + 1;
                    int temp = v[part];
                    v[part] = v[i];
                    v[i] = temp;
                }
            }
            int tempPivot = v[part + 1];
            v[part + 1] = v[fim];
            v[fim] = tempPivot;
            return (part + 1);
        }

        static void Main(string[] args)
        {
            int[] v = { 4, 1, 12, 3, 234, 2, 45, 22, };
            for (int i = 0; i < v.Length - 1; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine("");
            quicksort(v, 0, v.Length - 1);

            for (int i = 0; i < v.Length - 1; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
