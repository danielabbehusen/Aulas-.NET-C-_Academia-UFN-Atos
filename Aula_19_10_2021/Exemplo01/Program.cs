using System;

namespace Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {



            // Entrar com 3 notas de um aluno e imprimir a média(nota) final.

            double nota1, nota2, nota3, media;



            Console.WriteLine("Digite a nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média do aluno foi: " + media);
















            // exercicio 07
            //Ler um numero e mostrar seu antecessor e seu sucessor.


            //int aux;


            //Console.WriteLine("Digite um número: ");
            //aux = int.Parse(Console.ReadLine());



            //Console.WriteLine("Antecessor: " + (aux-1) + "\n" + "Sucessor: " + (aux+1));













            //exercicio 06
            //Para uma eleição, receba o numero de eleitores, a quantidade de votos brancos, nulos e validos.Mostre o percentual de cada tipo de voto.

            //int numeroEleitores, votosBrancos, votosNulos, votosValidos;
            //double percentualBrancos, percentualNulos, percentualValidos;


            //Console.WriteLine("Digite o numero de eleitores: ");
            //numeroEleitores = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o numero de votos brancos: ");
            //votosBrancos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de votos nulos: ");
            //votosNulos= int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de votos Validos: ");
            //votosValidos = int.Parse(Console.ReadLine());

            //percentualBrancos = (votosBrancos / (double)numeroEleitores) * 100;
            //percentualNulos = (votosNulos / (double)numeroEleitores) * 100;
            //percentualValidos = (votosValidos / (double)numeroEleitores) * 100;

            //Console.WriteLine("O percentual de votos brancos foi de: " + percentualBrancos + "%");
            //Console.WriteLine("O percentual de votos nulos foi de: " + percentualNulos + "%");
            //Console.WriteLine("O percentual de votos validos foi de: " + percentualValidos + "%");




























            // exercicio 05
            //Suponha que um vendedor de carros trabalhe em uma empresa onde todos os veículos custem 30.000 reais.Faça um programa que leia o nome do funcionário,
            //o seu salario base(Exemplo: 1000), e a quantidade de veículos vendidos. Para cada veiculo vendido ele recebe 15 % de comissão, que deve ser somado ao seu 
            //salario.Apresente o novo salario da mesma forma do exercício anterior.

            //string nomeFunc;
            //double salBase;
            //int qtdVeicVend;
            //double resultado;


            //Console.WriteLine("Digite o seu nome: ");
            //nomeFunc = Console.ReadLine();
            //Console.WriteLine("Digite o salario base: ");
            //salBase = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de veículos vendida: ");
            //qtdVeicVend = int.Parse(Console.ReadLine());



            //resultado = salBase + (qtdVeicVend * 4500);

            //Console.WriteLine("O novo salário é: " + resultado);


















            // exercicio 04
            // double salario;
            //double percentual;
            // double resultado;




            // Console.WriteLine("Digite o seu salário: ");
            // salario = double.Parse(Console.ReadLine());
            // Console.WriteLine("Digite o percentual de aumento: ");
            // percentual = double.Parse(Console.ReadLine());

            // resultado = salario + (salario * (percentual / 100));

            // Console.WriteLine("O novo salário com aumento é: " + resultado);



























            // exercicio 03
            //Ler um período em anos, meses e dias, e mostrar o total em dias. (considerando um ano com 365 dias e um mês com 30 dias).
            //int year;
            //int month;
            //int day;
            //int result;


            //Console.WriteLine("Digite a quantidade de  anos: ");
            //year = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite quantos meses: ");
            //month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite quantos dias: ");
            //day = int.Parse(Console.ReadLine());

            //result = (year * 365) + (month * 30) + day;

            //Console.WriteLine("A quantidade total em dias é:  " +result);












            // exercicio 02
            //int x = 5;
            //int y = 7;


            //int aux;
            //aux = x;
            //x = y;
            //y = aux;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
        }
    }
}
