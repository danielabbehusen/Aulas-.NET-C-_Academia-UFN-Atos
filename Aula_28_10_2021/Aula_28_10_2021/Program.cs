using System;

namespace Aula_28_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {






            
            double[] vetor = new double[30];
            int i;

            for (i = 0; i < 30; i++)
            {
                Console.Write(" ELEMENTO " + (i + 1) + " = ");
                vetor[i] = double.Parse(Console.ReadLine());
                
            }



            for (i = 0; i < 30; i++)
            {
               if(vetor[i] < 0)
                {
                    Console.WriteLine("Número " + vetor[i] + " na posição: " + i);
                }
            }
















            //ex07
            //int[] vetor1 = new int[20];
            //int[] vetor2 = new int[20];
            //int i;

            //for (i = 0; i < 20; i++)
            //{
            //    Console.Write(" VETOR '1' -> Elemento " + (i + 1) + " = ");
            //    vetor1[i] = int.Parse(Console.ReadLine());
            //    Console.Write(" VETOR '2' -> Elemento " + (i + 1) + " = ");
            //    vetor2[i] = int.Parse(Console.ReadLine());
            //}



            //for (i = 0; i < 20; i++)
            //{
            //    Console.WriteLine((vetor1[i] + vetor2[i]) + " ");
            //}











            //ex06
            //int[] vetor = new int[10];
            //int i, resultado;

            //for (i = 0; i < 10; i++)
            //{
            //    Console.Write("Elemento" + (i + 1) + " = ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}



            //for (i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine((vetor[i]) + " ");
            //}















            // ex05
            //int[] vetor = new int[10];
            //int i, resultado, pares = 0, impares = 0;

            //for (i = 0; i < 10; i++)
            //{
            //    Console.Write("Elemento" + (i + 1) + " = ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //for (i = 0; i < 10; i++)
            //{
            //    if (vetor[i] % 2 == 0)
            //    {

            //        pares++;
            //    }
            //    else
            //    {
            //        impares++;
            //    }
            //}

            //Console.WriteLine("A quantidade de numeros pares no vetor foi de: " + pares);
            //Console.WriteLine("A quantidade de numeros impares no vetor foi de: " + impares);














            //ex04 
            //int[] vetor = new int[5];
            //int i, resultado, pares = 0;

            //for (i = 0; i < 5; i++)
            //{
            //    Console.Write("Elemento" + (i + 1) + " = ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //for (i = 0; i < 5; i++)
            //{
            //    if (vetor[i] % 2 == 0)
            //    {
            //        Console.WriteLine(vetor[i] + " ");
            //        pares++;
            //    }
            //}

            //Console.Write("A quantidade de numeros pares no vetor foi de: " + pares);






            //ex03
            //int[] vetor = new int[10];
            //int i, resultado;

            //for (i = 0; i < 10; i++)
            //{
            //    Console.Write("Elemento" + (i + 1) + " = ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(vetor[i] + " ");
            //}

            //for(i = 0; i < 10; i++)
            //{
            //    Console.WriteLine((vetor[i] * 2) + " ");
            //}












            //ex02
            //int[] vetor = new int[10];
            //int i;

            //for(i =0; i < 10; i++)
            //{
            //    Console.Write("Elemento" + (i + 1) + " = ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(vetor[i] + " ");
            //}








            //ex01
            //int[] vetor;
            //int n, i;

            //Console.WriteLine("Digite um tamanho para o vetor: ");
            //n = int.Parse(Console.ReadLine());
            //vetor = new int[n];

            //for(i = 0; i < n; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //for(i = 1; i< n; i++)
            //{
            //    Console.Write(vetor[i] + " ");
            //}
        }
    }
}
