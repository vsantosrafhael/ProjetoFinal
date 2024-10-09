using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine(" Boa noite! Sejam Bem-Vindos \n Ao Menu de Exercícios:\n");
                Console.Write("Escolha uma opção:\n\n");
                Console.WriteLine("1 - Lista de Exercícios 1");
                Console.WriteLine("2 - Lista de Exercícios 2");
                Console.WriteLine("3 - Lista de Exercícios 3");
                Console.WriteLine("4 - Lista de Exercícios 4");
                Console.WriteLine("0 - Sair");
                

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuAtividades1();
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu a Lista de Exercícios 2.");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu a Lista de Exercícios 3.");
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu a Lista de Exercícios 4.");
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 0);

            
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

        static void MenuAtividades1()
        {
            int atividade;

            do
            {
                Console.Clear();
                Console.WriteLine("Atividades da Lista de Exercícios 1:");
                Console.WriteLine("1 - Atividade 1 (Olá, Mundo!)");
                Console.WriteLine("2 - Atividade 2 (Boas-Vindas)");
                Console.WriteLine("3 - Atividade 3 (Funcionário e Salário)");
                Console.WriteLine("4 - Atividade 4 (Somatório de Dois Números)");
                Console.WriteLine("5 - Atividade 5 (Média de Duas Notas)");
                Console.WriteLine("6 - Atividade 6 (Antecessor e Sucessor)");
                Console.WriteLine("7 - Atividade 7 (Dobro e Terça Parte)");
                Console.WriteLine("8 - Atividade 8 (Conversão de Distância)");
                Console.WriteLine("9 - Atividade 9 (Conversão de Reais para Dólares)");
                Console.WriteLine("10 - Atividade 10 (Cálculo da Área e Tinta)");
                Console.WriteLine("0 - Voltar ao menu principal");
                Console.Write("Escolha uma atividade: ");

                atividade = int.Parse(Console.ReadLine());

                switch (atividade)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Olá, Mundo! ");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Qual é seu nome? ");
                        String nome = Console.ReadLine();
                        Console.WriteLine($"Olá {nome}, é um prazer te conhecer! ");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Nome do Funcionário: ");
                        string funcionarioNome = Console.ReadLine();
                        Console.WriteLine("Salário: ");
                        decimal salario = decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"O funcionário {funcionarioNome} tem um salário de R${salario:F2} em Junho.");
                        break;
                    case 4:                        
                        Console.Clear();
                        Console.Write("Digite um valor: ");
                        int valor1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite outro valor: ");
                        int valor2 = int.Parse(Console.ReadLine());
                        int soma = valor1 + valor2;
                        Console.WriteLine($"A soma entre {valor1} e {valor2} é igual a {soma}.");
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Nota 1: ");
                        double nota1 = double.Parse(Console.ReadLine());
                        Console.Write("Nota 2: ");
                        double nota2 = double.Parse(Console.ReadLine());
                        double media = (nota1 + nota2) / 2;
                        Console.WriteLine($"A média entre {nota1} e {nota2} é igual a {media:F1}.");
                        break;
                    case 6:
                        Console.Clear();
                        Console.Write("Digite um número: ");
                        int numero = int.Parse(Console.ReadLine());
                        int antecessor = numero - 1;
                        int sucessor = numero + 1;
                        Console.WriteLine($"O antecessor de {numero} é {antecessor}.");
                        Console.WriteLine($"O sucessor de {numero} é {sucessor}.");
                        break;
                    case 7:
                        Console.Clear();
                        Console.Write("Digite um número: ");
                        double numeroReal = double.Parse(Console.ReadLine());
                        double dobro = numeroReal * 2;
                        double tercaParte = numeroReal / 3;
                        Console.WriteLine($"O dobro de {numeroReal} é {dobro}.");
                        Console.WriteLine($"A terça parte de {numeroReal} é {tercaParte}.");
                        break;
                    case 8:
                        Console.Clear();
                        Console.Write("Digite uma distância em metros: ");
                        double distanciaEmMetros = double.Parse(Console.ReadLine());

                        double quilometros = distanciaEmMetros / 1000;
                        double hectometros = distanciaEmMetros / 100;
                        double decametros = distanciaEmMetros / 10;
                        double decimetros = distanciaEmMetros * 10;
                        double centimetros = distanciaEmMetros * 100;
                        double milimetros = distanciaEmMetros * 1000;

                        Console.WriteLine($"A distância de {distanciaEmMetros}m corresponde a:");
                        Console.WriteLine($"{quilometros:F5} Km");
                        Console.WriteLine($"{hectometros:F4} Hm");
                        Console.WriteLine($"{decametros:F3} Dam");
                        Console.WriteLine($"{decimetros:F1} dm");
                        Console.WriteLine($"{centimetros:F1} cm");
                        Console.WriteLine($"{milimetros:F1} mm");
                        break;
                    case 9:
                        Console.Clear();
                        Console.Write("Digite quanto dinheiro você tem na carteira (em R$): ");
                        double valorEmReais = double.Parse(Console.ReadLine());
                        double cotacaoDolar = 3.45;
                        double quantidadeDolares = valorEmReais / cotacaoDolar;
                        Console.WriteLine($"Com R${valorEmReais:F2}, você pode comprar US${quantidadeDolares:F2}.");
                        break;
                    case 10:
                        Console.Clear();
                        Console.Write("Digite a largura da parede (em metros): ");
                        double largura = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura da parede (em metros): ");
                        double altura = double.Parse(Console.ReadLine());

                        double area = largura * altura;
                        double quantidadeTinta = area / 2;

                        Console.WriteLine($"A área a ser pintada é {area:F2} m².");
                        Console.WriteLine($"A quantidade de tinta necessária é {quantidadeTinta:F2} litros.");
                        break;
                    case 0:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                
                if (atividade != 0)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                }

            } while (atividade != 0);
        }
    }
}
    

