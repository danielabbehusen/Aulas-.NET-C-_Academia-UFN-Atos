using System;

namespace Aula_01_11_2021_Parte2
{
    class Program
    {

            static void mostraMensagem()
            {
                Console.WriteLine("Oi pessoal, tudo bem?");
            }
            static void mostrarNumero(int n)
            {
                Console.WriteLine("O número digitado foi: " + n);
            }
            static string lerNome()
            {
                string name;
                Console.WriteLine("Digite o nome: ");
                name = Console.ReadLine();
                return name;
            }
            static int somaValores(int n1, int n2)
            {
                int soma;
                soma = n1 + n2;
                return soma;
            }
            static int multiplicaValores(int n1, int n2)
            {
                return n1 * n2;
            }
            static Boolean retornaVerdade()
            {
                return true;
            }
            static void Main(string[] args)
            {
                int n, num1, num2, resultado;
                string nome;
                Console.WriteLine("Digite um numero: ");
                n = int.Parse(Console.ReadLine());
                mostrarNumero(n);
                mostraMensagem();
                nome = lerNome();
                Console.WriteLine("O nome digitado foi: " + nome);
                Console.WriteLine("Digite dois valores: ");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                resultado = somaValores(num1, num2);
                Console.WriteLine("O resultado da soma é: " + resultado);
                Console.WriteLine("O resultado da multiplicação é: " + multiplicaValores(num1, num2));
                string n2;
                n2 = Console.ReadLine();

           





























                //ex03
                /*Na cidade de Santa Maria, a quantidade de chuva, durante um mês de 30 dias, foi registrada. Desenvolva um 
                 * algoritmo para ler a quantidade de chuva em cada dia do mês, armazenando estes dados em um vetor e fazer o que se pede:
    Calcular e mostrar a média de chuva no mês;
    Encontrar a maior quantidade de chuva que ocorreu no mês e mostrar o respectivo dia;
    Mostrar os dias em que choveu acima da média e a respectiva quantidade de chuva*/
                //int[] dias = new int[30];
                //int i, total = 0, media, maior = 0;
                //Console.WriteLine("Digite as quantidades de chuva do mês: ");
                //for (i = 0; i < 30; i++)
                //{
                //    Console.WriteLine("Dia " + (i + 1));
                //    dias[i] = int.Parse(Console.ReadLine());
                //    if (dias[i] > maior)
                //        maior = i;
                //    total += dias[i];
                //}
                //media = total / 30;
                //Console.WriteLine("A média de chuva do mês foi: " + media);
                //Console.WriteLine("A maior chuva do mês ocorreu no dia " + (maior + 1) + " e foi " + dias[maior]);
                //for (i = 0; i < 30; i++)
                //{
                //    if (dias[i] > media)
                //        Console.WriteLine("Dia " + (i + 1) + " choveu " + dias[i] + " que foi mais que a média");
                //}














                //ex02

                //            A Federação Gaúcha de Futebol contratou um estudante de Ciência da Computação para fazer um levantamento estatístico do resultado de vários Grenais.Escreva um algoritmo que leia para cada Grenal, o número de gols marcados pelo Grêmio
                //            e o número de gols marcados pelo Internacional, imprimindo o nome do time vitorioso ou a palavra EMPATE.Após, ele deve escrever a mensagem:
                //            Novo Grenal(1.Sim 2.Não)?
                //e solicitar uma resposta. Se a resposta for 1, o algoritmo deve solicitar novamente o número de gols marcados pelos times em uma nova partida; se a resposta for 2, ele deve ser encerrado imprimindo:
                //• quantos Grenais fizeram parte da estatística;
                //• o número de vitórias do Grêmio;
                //• o número de vitórias do Internacional;
                //• o número de empates; e
                //• uma mensagem indicando qual o time que venceu o maior número de Grenais(ou “Não houve vencedor”).

                //int partidas = 0;
                //int vitInter = 0;
                //int vitGremio = 0;
                //int empates = 0;
                //int opcao = 0;
                //while (opcao != 2)
                //{
                //    string[] gols = Console.ReadLine().Split(' ');
                //    int golInter = int.Parse(gols[0]);
                //    int golGremio = int.Parse(gols[1]);
                //    partidas++;
                //    if (golInter > golGremio)
                //    {
                //        vitInter++;
                //    }
                //    else if (golGremio > golInter)
                //    {
                //        vitGremio++;
                //    }
                //    else
                //    {
                //        empates++;
                //    }
                //    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                //    opcao = int.Parse(Console.ReadLine());
                //}
                //Console.WriteLine(partidas + " grenais");
                //Console.WriteLine("Inter: " + vitInter);
                //Console.WriteLine("Gremio: " + vitGremio);
                //Console.WriteLine("Empates: " + empates);
                //if (vitInter > vitGremio)
                //{
                //    Console.WriteLine("Inter venceu mais");
                //}
                //else if (vitGremio > vitInter)
                //{
                //    Console.WriteLine("Gremio venceu mais");
                //}

















                //ex01

                //Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.Transpor uma matriz significa transformar suas linhas em colunas e vice - versa.

                //int[,] m1 = new int[3, 4];
                //int[,] m2 = new int[4, 3];
                //int i, j;
                //Random rnd = new Random();
                //Console.WriteLine("Entre com a primeira matriz: ");
                //for ( i = 0; i < 3; i++)
                //{
                //    for (j = 0; j < 4; j++)
                //    {
                //        m1[i, j] = int.Parse(Console.ReadLine());
                //    }
                //}




            }
    }
}
