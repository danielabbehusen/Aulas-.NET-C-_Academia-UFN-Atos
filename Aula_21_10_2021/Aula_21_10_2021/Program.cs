using System;

namespace Aula_21_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {




            //ex11
            //Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e então mostre na tela todos os números de 0 a 100, pulando de x em x.


            //int i, x;
            //Console.WriteLine("Digite um numero inteiro:");
            //x = int.Parse(Console.ReadLine());

            //for (i = 0; i <= 100; i=i+x) {
            //    Console.WriteLine("\n" +i);

            //}




            // ex10
            //int inicio, fim;
            //Console.WriteLine("Digite dois numeros inteiros: ");
            //inicio = int.Parse(Console.ReadLine());
            //fim = int.Parse(Console.ReadLine());

            //if (fim > inicio)
            //{
            //    for (++inicio; inicio < fim; inicio++)
            //    {
            //        Console.Write("valor: " + inicio + "\n");
            //    }
            //}else if(fim < inicio)
            //{
            //    for (--inicio; inicio > fim; inicio--)
            //    {
            //        Console.Write("valor: " + inicio + "\n");
            //    }
            //}





            //ex09
            //int i;
            //for(i = 20; i >= 5; i--)
            //{
            //    Console.WriteLine("Valor de i = " + i);
            //}




            //ex08
            //int i;
            //for( i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("i vale " + i);
            //}











            //ex07
            //int numero;
            //int x;
            //Console.WriteLine("Digite um número inteiro: ");
            //numero = int.Parse(Console.ReadLine());

            // x = (numero % 2 == 0) ? x = numero : x = (++numero);

            //Console.WriteLine("O número é: " +x);



            // ex06
            //Operador ternário -> tudo que o ternario faz, o if faz...
            //    FormatException simplificada da estrutura if-else -> não é muito usual
            //    operador ternario "?"
            //    condição ? instrução1 : instrução2

            //int i;
            //char x;
            //Console.WriteLine("Digite um valor: ");
            //i = int.Parse(Console.ReadLine());
            //// Se o numero digitado for par, eu quero mostrar "p" e se for impar "i" na tela
            //x = (i % 2 == 0) ? x = 'p' : x = 'i';
            //Console.WriteLine("Resultado do operador ternário: " + x);












            // ex05
            //Uma loja fornece 10 % de desconto para funcionários e 5 % de desconto para clientes vips. Faça um programa que calcule o valor total a ser pago por uma pessoa. 
            //                O programa deverá ler o valor total da compra efetuada e um código que identifique se o comprador é um cliente comum(1), funcionário(2) ou vip(3)

            //double totalCompra;
            //int codigo;

            //Console.WriteLine("Digite o valor total da compra: ");
            //totalCompra = double.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o tipo de cliente? \n1 - Comum\n2 - Funcionário\n3 - VIP");
            //codigo = int.Parse(Console.ReadLine());

            //switch (codigo)
            //{
            //    case 1:

            //        Console.WriteLine("O total a ser pago é de : " + totalCompra);
            //        break;

            //    case 2:
            //        totalCompra = totalCompra - (totalCompra * 0.10);
            //        Console.WriteLine("O total a ser pago é de : " + totalCompra);
            //        break;
            //    case 3:
            //        totalCompra = totalCompra - (totalCompra * 0.05);
            //        Console.WriteLine("O total a ser pago é de : " + totalCompra);
            //        break;
            //    default:
            //        Console.WriteLine("Código inválido!");
            //        break;
            //}









            // ex04
            //Implemente na calculadora desenvolvida as seguintes funções: Se a operação digitada for “+”,
            //será efetuada a soma; Se a operação digitada for “-”, será efetuada a subtração; Se a operação digitada for “x”, 
            //         será efetuada a multiplicação Se a operação digitada for “/”, será efetuada a divisão; Se não for inserida nenhuma das operações anteriores, 
            //              deve ser apresentado uma mensagem para digitar uma operação válida e apresente o resultado das quatro operações.

            //char operacao;
            //int n1, n2;

            //Console.WriteLine("Digite dois números para efetuar a operação desejada: ");
            //n1 = int.Parse(Console.ReadLine());
            //n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o tipo operação desejada: ");
            //operacao = char.Parse(Console.ReadLine());

            //switch (operacao)
            //{
            //    case '+':
            //        Console.WriteLine("A soma dos dois números é: " + (n1 + n2));
            //        break;
            //    case '-':
            //        Console.WriteLine("A subtração dos dois números é: " + (n1 - n2));
            //        break;

            //    case '*':
            //        Console.WriteLine("A multiplicação dos dois números é: " + (n1 * n2));
            //        break;

            //    case '/':
            //        Console.WriteLine("A divisão dos dois números é: " + (n1 / n2));
            //        break;
            //    default:
            //        Console.WriteLine("Operação inválida!");
            //        break;
            //}





























            // ex03
            // Escreva um programa que pede para o usuário digitar um valor entre 1 e 12,
            // e então mostre na tela o mês correspondente. Caso o usuário digite um valor fora do intervalo, mostre uma mensagem indicando que é um mês inválido.
            //int valor;
            //Console.WriteLine("Digite um valor de 1 à 12: ");
            //valor = int.Parse(Console.ReadLine());

            //switch (valor)
            //{
            //    case 1:
            //        Console.WriteLine("Janeiro");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fevereiro");
            //        break;
            //    case 3:
            //        Console.WriteLine("Março");
            //        break;
            //    case 4:
            //        Console.WriteLine("Abril");
            //        break;
            //    case 5:
            //        Console.WriteLine("Maio");
            //        break;
            //    case 6:
            //        Console.WriteLine("Junho");
            //        break;
            //    case 7:
            //        Console.WriteLine("Julho");
            //        break;
            //    case 8:
            //        Console.WriteLine("Agosto");
            //        break;
            //    case 9:
            //        Console.WriteLine("Setembro");
            //        break;
            //    case 10:
            //        Console.WriteLine("Outubro");
            //        break;
            //    case 11:
            //        Console.WriteLine("Novembro");
            //        break;
            //    case 12:
            //        Console.WriteLine("Dezembro");
            //        break;
            //    default:
            //        Console.WriteLine("Mês inválido!");
            //        break;

            //}





















            // ex02
            //char letra;
            //Console.WriteLine("Digite uma letra ou caractere");
            //letra = char.Parse(Console.ReadLine());
            //switch (letra)
            //{
            //    case 'r':
            //        Console.WriteLine("A letra digitada foi r");
            //        break;
            //    case ':':
            //        Console.WriteLine("Foi digitado :");
            //        break;
            //    case '1':
            //        Console.WriteLine("Foi digitado 1");
            //        break;
            //    default:
            //        Console.WriteLine("Não foi digitado nada que prestasse");
            //        break;
            //}











            //ex01
            ////estruturas condicionais 
            //// criar if, else if, if dentro if 
            ///* switch case -> estruturas seletivas -> selecionar -> menu -> servir para criar menus e comparações mais "simples"
            // só funciona/compara inteiro e caracteres -> não poderemos comparar strings (existem funçoes), pontos flutuantes como float e double
            // */
            //int n, x;
            //Console.WriteLine("Digite um número ");
            //n = int.Parse(Console.ReadLine());
            //switch (n) // variável de controle será o N, ou seja, as comparações serão nesta variável
            //{
            //    case 0:
            //        Console.WriteLine("O n vale 0");
            //        x = 11;
            //        Console.WriteLine("Oi");
            //        break; //} pra finalizar este case é break
            //    case 10:
            //        Console.WriteLine("O n vale 10");
            //        x = 11; // atribuição
            //        Console.WriteLine("O valor do x é " + x);
            //        x = x * 2;
            //        Console.WriteLine("O valor do agora x é " + x);
            //        break;
            //    case 5:
            //        Console.WriteLine("Digitou 5");
            //        break;
            //    default:
            //        Console.WriteLine("Digite um valor válido!");
            //        break;
            //}
        }
    }
}