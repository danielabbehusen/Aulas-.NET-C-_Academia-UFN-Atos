using System;

namespace Aula_25_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {


            //            Os dois primeiros números da sequência de Fibonacci são 0 e 1.Qualquer outro número desta sequência pode ser calculado pela soma dos dois imediatamente anteriores: F0 = 0; F1 = 1; Fn = Fn−1 + Fn−2

            //Os primeiros números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

            //Fazer um algoritmo que leia um número N e mostre os primeiros N números da série de Fibonacci.

            int n, i, ant, antant, fib;
            Console.WriteLine("Digite um valor para N: ");
            n = int.Parse(Console.ReadLine());
            ant = 1;
            antant = 0;
            if (n <= 0)
            {
                Console.WriteLine("Digite um número maior que 0");
            }
            else
            {
                Console.WriteLine("A sequência de fibonacci é: ");
                if (n == 1)
                    Console.Write(antant);
                else if (n == 2)
                    Console.Write(antant + " " + ant + " ");
                else
                {
                    Console.Write(antant + " " + ant + " ");
                    for (i = 2; i <= n; i++)
                    {
                        fib = ant + antant;
                        Console.Write(fib + " ");
                        antant = ant;
                        ant = fib;
                    }
                }

            }







        // Faça um programa que leia um número n e imprima se ele é primo ou não. (um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)
        //int x, cont = 0;

        //Console.WriteLine("Digite um número inteiro: ");
        //x = int.Parse(Console.ReadLine());


        //    for (int i = 1; i <= x; i++)
        //    {
        //        if (x % i == 0)
        //        {
        //            cont++;
        //        }


        //    }
        //    if (cont == 2)
        //    {
        //        Console.WriteLine(x + " É primo!!!");
        //    }
        //    else
        //    {
        //        Console.WriteLine(x + " Não é primo!!!");
        //    }





        //int x;
        //double soma = 1;
        //Console.WriteLine("Digite um número inteiro: ");
        //x = int.Parse(Console.ReadLine());

        //for(int i =1; i <=x; i++)
        //{
        //    soma += 1 / (double)i;
        //    Console.WriteLine("1" + "/" +i );
        //}

        //Console.WriteLine("O resultado da expressão foi: " + Math.Round(Convert.ToDecimal(soma), 2));








        //int i, m, d, soma, p;
        //for(i = 1000; i <= 9999; i++)
        //{
        //    m = i / 100;
        //    d = i % 100;
        //    soma = d + m;
        //    p = soma * soma;

        //    if(p == i)
        //    {
        //        Console.WriteLine(i + " Satisfaz as regras");
        //    }
        //    //Console.WriteLine("i = " +i + " i/10 ="+ i / 10 + " i/100=" +i / 100);
        //    //Console.WriteLine("i = " + i + " i%10 =" + i % 10 + " i/100=" + i % 100);
        //}


        // desafio aula passada
        //int num = 1000, i;
        //double somaP = 0, somaI = 0; // Essas duas variáveis foram criadas porque quando o i é par ele é negativo na expressão, quando ele é impar ele é positivo, e no final realizo a soma dos dois multiplicando o somaP por -1


        //for (i = 1; i <= 50; i++)
        //{
        //    if (i % 2 == 0)
        //    {

        //        somaP += (double)num / i;
        //        Console.WriteLine(num + "/" + i + " = " + Math.Round(Convert.ToDecimal((double)num / i), 2));
        //        num -= 3;


        //    }
        //    else
        //    {

        //        somaI += (double)num / i;
        //        Console.WriteLine(num + "/" + i + " = " + Math.Round(Convert.ToDecimal((double)num / i), 2));
        //        num -= 3;

        //    }

        //}
        //Console.WriteLine("A soma total da expressão foi de: " + Math.Round(Convert.ToDecimal(somaI + (somaP * -1)), 2));





        //int x;
        //x = int.Parse(Console.ReadLine());

        //while(x != 0)
        //{
        //    if(x%2 == 0)
        //    {
        //        Console.WriteLine( x + " É par" + "\n");
        //        x = int.Parse(Console.ReadLine());
        //    }
        //    else
        //    {
        //        Console.WriteLine(x + " É ímpar" + "\n");
        //        x = int.Parse(Console.ReadLine());
        //    }
        //}









        //int num = 1000, i;
        //double soma = 0;

        //for (i = 1; i <= 50; i++)
        //{
        //    soma = soma + (num / i) * (Math.Pow(-1, (i - 1)));
        //    num = num - 3;
        //}

        //Console.WriteLine("A somatória é: " + soma);














        //int i = 0;
        //while (i < 10)
        //{
        //    Console.WriteLine(i);

        //    i++;
        //}
    }
    }
}
