using System;

namespace Aula_22_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = 1000, i;
            double soma = 0;

            for(i = 1; i<=50; i++)
            {
                soma = soma + (num / i) * (Math.Pow(-1, (i - 1)));
                num = num - 3;
            }

            Console.WriteLine("A somatória é: " +soma);





            //int k, i;
            //double resultadoP= 0, resultadoN= 0;

            //for (i = 1000, k = 1; i > 850; i-= 3, k += 1)
            //{
            //    if(k%2 == 0)
            //    {

            //        resultadoN = resultadoN + (i/k) * -1;
            //    }
            //    else
            //    {
            //        resultadoP += resultadoP + (i / k);
            //    }
            //}

            //Console.WriteLine("O resultado da expressão foi: " + (resultadoN + resultadoP));













            //ex12
            //int i, n, resultado = 1;
            //Console.WriteLine("Digite o número que deseja calcular o fatorial: ");
            // n = int.Parse(Console.ReadLine());

            //for(i = 1; i<= n; i++)
            //{
            //    resultado *= i;
            //}

            //Console.WriteLine(resultado);





            //ex11
            //for(int i =1; i <=20; i++)
            //{
            //    Console.WriteLine(i + "cm em polegada é: " + (i * 2.54) + "inch");
            //}









            //ex10
            //int i, j;
            //for (i = 0; i <= 10; i++)
            //{
            //    for (j = 0; j <= 10; j++)
            //    {
            //        Console.WriteLine(i + "*" + j + " = " + (i * j));
            //    }
            //    Console.WriteLine("---------------------------------");
            //}
        
















        //ex09
        /*Escreva um algoritmo leia pelo teclado o valor de uma variável inteira chamada opcao, porém,
        * o programa só pode seguir sua execução caso o valor de opcao seja entre 1 e 4.Se o valor 
        * digitado não for entre 1 e 4, a variável opcao deverá ser lida novamente pelo teclado
        * */
        //int opcao, i;
        //for (i = 0; true; i++)
        //{
        //    Console.WriteLine("Digite uma opção de 1 a 4: ");
        //    opcao = int.Parse(Console.ReadLine());
        //    if (opcao > 4 || opcao < 1)
        //    {
        //        Console.WriteLine("Digite um valor entre 1 e 4");
        //        continue;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Escolhida a opção " + opcao);
        //        break;
        //    }
        //    /*if (opcao >= 1 && opcao <= 4)
        //    {
        //        break;
        //    }*/
        //}
        //switch (opcao)
        //{
        //    case 1:
        //        Console.WriteLine("Escolhida esta maravilhosa opção 1 no switch case no nosso menu modelo");
        //        break;
        //    case 2:
        //        Console.WriteLine("Escolhida esta maravilhosa opção 2 no switch case no nosso menu modelo");
        //        break;
        //    case 3:
        //        Console.WriteLine("Escolhida esta maravilhosa opção 3 no switch case no nosso menu modelo");
        //        break;
        //    case 4:
        //        Console.WriteLine("Escolhida esta maravilhosa opção 4 no switch case no nosso menu modelo");
        //        break;
        //    default:
        //        Console.WriteLine("Escolha uma função válida");
        //        break;
        //}





        //ex08
        //int i, j;
        //for (i = 0, j = 10; i < 10 && j < 20; i++, j = j + 2) //while(true)
        //{
        //    Console.WriteLine("I = " + i + " J = " + j);
        //}





        //ex07
        /*Escreva um algoritmo leia continuamente pelo teclado o valor de uma variável inteira chamada
            op, e só finalize a execução do programa quando o valor lido para op seja zero.*/
        //int op, i;
        //for (i = 0; true; i++) //while(true)
        //{
        //    Console.WriteLine("Digite um valor para op");
        //    op = int.Parse(Console.ReadLine());
        //    if (op == 0)
        //    {
        //        break;
        //    }

        //}






















        ////ex06
        //int i;
        //for (i = 0; i < 20; i++)
        //{
        //    if (i == 11)
        //    {
        //        break;
        //    }
        //    if (i == 7)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine("O i é = " + i);
        //}













        //ex05
        //int inicial, final;
        //char escolha;

        //Console.WriteLine("Digite um valor inicial e outro final:");
        //inicial = int.Parse(Console.ReadLine());
        //final = int.Parse(Console.ReadLine());
        //Console.WriteLine("Você quer pular os valores pares ou os ímpares? P - Pares | I - Impares");
        //escolha = char.Parse(Console.ReadLine());

        //if(inicial > final)
        //{
        //    for (int i = final; i <= inicial; i++)
        //    {
        //        if (escolha == 'P')
        //        {
        //            if (i % 2 == 0)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        }
        //        else if (escolha == 'I')
        //        {
        //            if (i % 2 != 0)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Código incorreto");
        //        }
        //    }
        //}
        //else
        //{
        //    for (int i = inicial; i <= final; i++)
        //    {
        //        if (escolha == 'P')
        //        {
        //            if (i % 2 == 0)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        }
        //        else if (escolha == 'I')
        //        {
        //            if(i%2 != 0)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Código incorreto");
        //        }

        //    }
        //}















        //ex04
        //for(int i = 1001; i<1999; i++)
        //{
        //    if(i%11 == 5)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}



        // ex03
        //int x;
        //Console.WriteLine("Digite um número inteiro: ");
        //x = int.Parse(Console.ReadLine());

        //for(int i =1; i <= x; i++)
        //{
        //    Console.WriteLine(x + " X " + i + " = " + (x*i));
        //}







        //ex02
        //int qtdAlunos, n1, n2, n3;
        //double media;


        //Console.WriteLine("Digite a quantidade de alunos da turma: ");
        //qtdAlunos = int.Parse(Console.ReadLine());

        //for(int i =1; i <= qtdAlunos; i++)
        //{
        //    Console.WriteLine("\nAluno " + i);
        //    Console.WriteLine("\nNota 1: ");
        //    n1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Nota 2: ");
        //    n2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Nota 3: ");
        //    n3 = int.Parse(Console.ReadLine());
        //    media = (n1 + n2 + (double)n3) / 3;


        //    Console.WriteLine("\nSua média final é: " +(media.ToString("0.00")));
        //    if(media >= 6)
        //    {
        //        Console.WriteLine("Aprovado\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Reprovado\n");
        //    }


        //}







        //ex 01

        //int x, i;

        //Console.WriteLine("Digite um valor para x: ");
        //x = int.Parse(Console.ReadLine());

        //for(i = 0; i <= 100; i++)
        //{
        //    if(i % x == 0)
        //    {
        //        Console.WriteLine("O número " +i + " é divisível por " + x);
        //    }
        //}

    }
    }
}
