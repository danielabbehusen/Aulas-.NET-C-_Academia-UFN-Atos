using System;
using System.Collections.Generic;

namespace Aula_29_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> listaint = new List<int>();
            listaint.Add(1);
            listaint.Add(2);
            listaint.Add(3);
            listaint.Add(4);
            listaint.Add(5);
            foreach (int item in listaint)
                Console.WriteLine(item);
            Console.WriteLine(" count " + listaint.Count);














            //ex07
            //Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal(da esquerda para a direita) 
            //    são os mesmos da diagonal secundária(direita pra esquerda).


            //int[,] vet1 = new int[5, 5];
            //int var1 = 0;
            //int var2 = 0;
            //int som = 0;
            //for (int i = 0; i < vet1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < vet1.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Elemento da LINHA {0} e COLUNA {1}: ", i, j);
            //        vet1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < vet1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < vet1.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            var1 = vet1[i, j];
            //        }
            //        else if (i + j == vet1.GetLength(0) - 1)
            //        {
            //            var2 = vet1[i, j];
            //        }
            //    }
            //    if (var1 == var2)
            //    {
            //        som++;
            //    }
            //}
            //if (som == vet1.GetLength(0))
            //{
            //    Console.WriteLine("Os numeros são iguais");
            //}
            //else
            //{
            //    Console.WriteLine("Os numeros são diferentes");
            //}













            //ex06
            //Escreva um programa que leia uma matriz de ordem 3(ou seja, 3x3) e verifique se a
            //*soma dos elementos da diagonal principal é igual a soma dos elementos da diagonal secundária.
            //int[,] mat = new int[3, 3];
            //int i, j, sp = 0, ss = 0;
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        //mat[i, j] = i * j;
            //        mat[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        if (i == j)
            //            sp += mat[i, j];
            //        if ((i + j) == 2)
            //            ss += mat[i, j];
            //    }
            //}
            //if (sp == ss)
            //    Console.WriteLine("As somas são iguais!");
            //else
            //    Console.WriteLine("Não são iguais!");







            //ex05 
            ////Escreva um programa em C# que faça atribuição automática dos valores da matriz 3x3, utilizando os índices. Em seguida apresente os valores da diagonal principal.
            ////int[,] mat = new int[3, 3];
            //int[,] mat = new int[3, 3];
            //int i, j;
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        mat[i, j] = i * j;
            //    }
            //}
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        if (i == j)
            //            Console.WriteLine("elemento da linha " + i + " e coluna " + j + " = " + mat[i, j]);
            //    }
            //}







            //ex04
            /*Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela
            * apenas os valores cuja soma dos índices (i+j) seja um número par.
            * Neste mesmo programa, muliplique toda a segunda coluna por dois e multiplique por 3 a terceira linha. *
            * */

            //int[,] mat = new int[4, 3];
            //int i, j, soma = 0; ;
            //for (i = 0; i < 4; i++) //linha
            //{
            //    for (j = 0; j < 3; j++) //coluna
            //    {
            //        Console.WriteLine("Digite o elemento [" + i + "] - [" + j + "]");
            //        mat[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (i = 0; i < 4; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //            Console.WriteLine(mat[i, j]);
            //    }
            //}
            //for (i = 0; i < 4; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        if (j == 1)
            //            mat[i, j] = mat[i, j] * 2;
            //        if (i == 2)
            //            mat[i, j] = mat[i, j] * 3;
            //    }
            //}
            //for (i = 0; i < 4; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        Console.Write(mat[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}











            //ex03
            //   Ler uma matriz de dimensão 4x4 e fazer um somatório de todos os elementos.
            //int[,] mat = new int[4, 4];
            //Console.WriteLine(mat.Length);
            //int i, j, soma = 0; ;
            //for (i = 0; i < 4; i++) //linha
            //{
            //    for (j = 0; j < 4; j++) //coluna
            //    {
            //        Console.WriteLine("Digite o elemento [" + i + "] - [" + j + "]");
            //        mat[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (i = 0; i < 4; i++)
            //{
            //    for (j = 0; j < 4; j++)
            //    {
            //        soma += mat[i, j];
            //    }
            //}
            //Console.WriteLine(soma);











            //ex02
            /*/Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo 
             * os valores nulos por 2. Mostre os vetores lidos e o vetor resultado. */
            //int[] vetor = new int[20];
            //int[] nvetor = new int[20];
            //int i;
            //for (i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Digite o elemento " + (i + 1));
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //for (i = 0; i < 20; i++)
            //{
            //    if (vetor[i] == 0)
            //        nvetor[i] = 2;
            //    else
            //        nvetor[i] = vetor[i];
            //}
            //Console.WriteLine("Vetor original: ");
            //for (i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Elemento " + (i + 1) + " = " + vetor[i]);
            //}
            //Console.WriteLine("Vetor novo: ");
            //for (i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Elemento " + (i + 1) + " = " + nvetor[i]);
            //}






            //ex01
            //int[] vetor = new int[10];
            //int[] nvetor = new int[10];
            //int i, p;
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Digite o elemento " + (i + 1));
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //for (i = 0, p = 0; i < 10; i++)
            //{
            //    if (vetor[i] % 2 == 0)
            //    {
            //        nvetor[p] = vetor[i];
            //        p++;
            //    }
            //}
            //for (i = 0; i < 10; i++)
            //{
            //    if (vetor[i] % 2 != 0)
            //    {
            //        nvetor[p] = vetor[i];
            //        p++;
            //    }
            //}
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Elemento " + (i + 1) + " = " + nvetor[i]);
            //}
        }
    }
}
