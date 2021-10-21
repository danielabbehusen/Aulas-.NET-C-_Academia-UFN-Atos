using System;

namespace Aula_20_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {


            // ex07
            //Para doar sangue é necessário ter entre 18 e 67 anos.Faça um aplicativo que pergunte a idade de uma pessoa e diga se ela pode doar sangue ou não.Use alguns dos 
            //    operadores lógicos OU(||) e E(&&).



            //int idade;

            //Console.Write("Digite a sua idade: ");
            //idade = int.Parse(Console.ReadLine());

            //if(idade >= 18 && idade <= 67)
            //{
            //    Console.WriteLine("Pode doar sangue");
            //}
            //else
            //{
            //    Console.WriteLine("Não pode doar sangue");
            //}







            // ex06
            //int n1, n2, n3;

            //Console.WriteLine("Digite os três lados do triângulo: ");
            //n1 = int.Parse(Console.ReadLine());
            //n2 = int.Parse(Console.ReadLine());
            //n3 = int.Parse(Console.ReadLine());

            //if( n1 <(n2+n3) && n2 < (n1+n3) && n3 < (n1 + n2))
            //{
            //    if(n1 == n2 && n2 == n3 && n3 == n1)
            //    {
            //        Console.WriteLine("Triângulo Equilátero, todos os lados iguais");
            //    }else if(n1 == n2 || n1 == n3 || n2 == n3)
            //    {
            //        Console.WriteLine("Triângulo Isósceles, dois lados iguais");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Triângulo Escaleno, todos os lados distintos");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Não é triângulo :'(");
            //}























            // ex05
            //int valor;
            //Console.WriteLine("Informe um valor:");
            //valor = int.Parse(Console.ReadLine());


            //if (valor % 2 == 0)
            //{
            //    Console.WriteLine("O valor é par!");
            //}
            //else
            //{
            //    Console.WriteLine("O valor é impar!");
            //}







            // ex04
            //double salario;

            //Console.WriteLine("Digite o salário:");
            //salario = double.Parse(Console.ReadLine());

            //if(salario <= 900)
            //{
            //    Console.WriteLine("Salario Atual: " + salario + "\nNovo salário: " + (salario + (salario * 0.05)) + "\nPorcentagem de aumento: 5%" + "\nQuantidade do aumento: " + (salario * 0.05));
            //}else if(salario >= 901 && salario <= 1400)
            //{
            //    Console.WriteLine("\nSalario Atual: " + salario + "\nNovo salário: " + (salario + (salario * 0.08)) + "\nPorcentagem de aumento: 8%" + "\nQuantidade do aumento: " + (salario * 0.08));
            //}
            //else
            //{
            //    Console.WriteLine("Salario Atual: " + salario + "\nNovo salário: " + (salario + (salario * 0.10)) + "\nPorcentagem de aumento: 10%" + "\nQuantidade do aumento: " + (salario * 0.10));
            //}


            // ex03
            //            Leia 2 números do usuário, após isso, mostre esta mensagem ao usuário:
            //“Informe 1 para soma, 2 para subtração, 3 para multiplicação e 4 para divisão”
            //Leia a escolha do usuário e faça o que ele pediu!

            //int n1, n2, operacao;
            //double resultado;

            //Console.WriteLine("Digite o primeiro número: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número: ");
            //n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o tipo de operação: 1 - Soma | 2 - Subtração | 3 - Multiplicação | 4 - Divisão ");
            //operacao = int.Parse(Console.ReadLine());

            //if(operacao == 1)
            //{
            //    Console.WriteLine("A soma dos dois números foi: " + (n1 + n2));
            //}
            //else if(operacao == 2)
            //{
            //    Console.WriteLine("A subtração dos dois números foi: " + (n1 - n2));
            //}else if(operacao == 3)
            //{
            //    Console.WriteLine("A multiplicação dos dois números foi: " + (n1 * n2));
            //}
            //else if(operacao == 4)
            //{
            //    Console.WriteLine("A divisão dos dois números foi: " + (n1 / (double)n2));
            //}
            //else
            //{
            //    Console.WriteLine("Operação inválida");
            //}






            // ex02
            //            Declare uma variável int e armazene um valor qualquer nela(direto no código fonte).Depois disso, solicite ao usuário informar um numero!
            //Verifique se o numero que o usuário digitou é igual ao que você armazenou ou não, e informe isto ao usuário!
            // parte2: Se o usuário errou, diga se o numero que ele digitou é maior ou menor que o valor armazenado!

            //int valor = 5;
            //int valorUser;

            //Console.WriteLine("Digite um valor: ");
            //valorUser = int.Parse(Console.ReadLine());

            //if (valor == valorUser)
            //{
            //    Console.WriteLine("Valores Iguais");
            //}
            //else
            //{
            //    if(valor < valorUser)
            //    {
            //        Console.WriteLine("Você errou: O valor que você digitou é maior que o fornecido");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Você errou: O valor que você digitou é menor que o fornecido");
            //    }
            //}






            // ex01
            //int valor;

            //Console.WriteLine("Digite um valor: ");
            //valor = int.Parse(Console.ReadLine());

            //if(valor > 0)
            //{
            //    Console.WriteLine("O valor é positivo!");
            //}
            //else
            //{
            //    Console.WriteLine("O valor não é positivo");
            //}
        }
    }
}
