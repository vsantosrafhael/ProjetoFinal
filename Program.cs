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
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine(" Boa noite! Sejam Bem-Vindos \n Ao Menu de Exercícios:\n");
                Console.Write("Escolha uma opção:\n\n");
                Console.WriteLine("1 - Lista de Exercícios 1");
                Console.WriteLine("2 - Lista de Exercícios 2");
                Console.WriteLine("3 - Lista de Exercícios 3");
                Console.WriteLine("4 - Lista de Exercícios 4\n");
                Console.WriteLine("0 - Sair");


                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuAtividades1();
                        break;
                    case 2:
                        MenuAtividades2();
                        break;
                    case 3:
                        MenuAtividades3();
                        break;
                    case 4:
                        MenuAtividades4();
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
                Console.WriteLine("Atividades da Lista de Exercícios 1:\n");
                Console.WriteLine("1 - Atividade 1 (Olá, Mundo!)");
                Console.WriteLine("2 - Atividade 2 (Boas-Vindas)");
                Console.WriteLine("3 - Atividade 3 (Funcionário e Salário)");
                Console.WriteLine("4 - Atividade 4 (Somatório de Dois Números)");
                Console.WriteLine("5 - Atividade 5 (Média de Duas Notas)");
                Console.WriteLine("6 - Atividade 6 (Antecessor e Sucessor)");
                Console.WriteLine("7 - Atividade 7 (Dobro e Terça Parte)");
                Console.WriteLine("8 - Atividade 8 (Conversão de Distância)");
                Console.WriteLine("9 - Atividade 9 (Conversão de Reais para Dólares)");
                Console.WriteLine("10 - Atividade 10 (Cálculo da Área e Tinta)\n");
                Console.WriteLine("0 - Voltar ao menu principal\n");
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
        static void MenuAtividades2()
        {
            int atividade;

            do
            {
                Console.Clear();
                Console.WriteLine("Atividades da Lista de Exercícios 2:\n");
                Console.WriteLine("1 - Atividade 1 (Verificar número maior que 20)");
                Console.WriteLine("2 - Atividade 2 (Verificar se o valor é maior que 10)");
                Console.WriteLine("3 - Atividade 3 (Verificar se a soma de A + B é menor que C)");
                Console.WriteLine("4 - Atividade 4 (Adição de dois números e verificar resultado)");
                Console.WriteLine("5 - Atividade 5 (Informações de uma pessoa (sexo e estado civil)");
                Console.WriteLine("6 - Atividade 6 (Verificar se um número é par ou ímpar)");
                Console.WriteLine("7 - Atividade 7 (Comparar e calcular A e B)");
                Console.WriteLine("8 - Atividade 8 (Dobro ou triplo de um número)");
                Console.WriteLine("9 - Atividade 9 (Ordenar 3 valores do maior para o menor)");
                Console.WriteLine("10 - Atividade 10 (Ordenar 3 valores do menor para o maior)");
                Console.WriteLine("11 - Atividade 11 (Duração de um jogo de Xadrez)\n");
                Console.WriteLine("0 - Voltar ao menu principal\n");
                Console.Write("Escolha uma atividade: ");

                atividade = int.Parse(Console.ReadLine());

                switch (atividade)
                {
                    case 1: Atividade1(); break;
                    case 2: Atividade2(); break;
                    case 3: Atividade3(); break;
                    case 4: Atividade4(); break;
                    case 5: Atividade5(); break;
                    case 6: Atividade6(); break;
                    case 7: Atividade7(); break;
                    case 8: Atividade8(); break;
                    case 9: Atividade9(); break;
                    case 10: Atividade10(); break;
                    case 11: Atividade11(); break;
                    case 0: Console.WriteLine("Voltando ao menu principal..."); break;
                    default: Console.WriteLine("Opção inválida. Tente novamente."); break;
                }

                if (atividade != 0)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                }

            } while (atividade != 0);
        }


        static void Atividade1()
        {
            Console.Clear();
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 20)
                Console.WriteLine($"O número {numero} é maior que 20.");
            else
                Console.WriteLine($"O número {numero} não é maior que 20.");
        }

        static void Atividade2()
        {
            Console.Clear();
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());
            if (valor > 10)
                Console.WriteLine("É MAIOR QUE 10!");
            else
                Console.WriteLine("NÃO É MAIOR QUE 10!");
        }

        static void Atividade3()
        {
            Console.Clear();
            Console.Write("Digite A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Digite C: ");
            int C = int.Parse(Console.ReadLine());
            if (A + B < C)
                Console.WriteLine($"A soma de A + B ({A + B}) é menor que C ({C}).");
            else
                Console.WriteLine($"A soma de A + B ({A + B}) não é menor que C ({C}).");
        }

        static void Atividade4()
        {
            Console.Clear();
            Console.Write("Digite um número A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite um número B: ");
            int B = int.Parse(Console.ReadLine());
            int resultado = A + B;
            if (resultado > 10)
                Console.WriteLine($"A soma de A e B é {resultado}, que é maior que 10.");
        }

        static void Atividade5()
        {
            Console.Clear();
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu sexo (M/F): ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Digite seu estado civil: ");
            string estadoCivil = Console.ReadLine().ToUpper();

            if (sexo == 'F' && estadoCivil == "CASADA")
            {
                Console.Write("Quantos anos está casada? ");
                int anosCasada = int.Parse(Console.ReadLine());
                Console.WriteLine($"Olá {nome}, você está casada há {anosCasada} anos.");
            }
        }

        static void Atividade6()
        {
            Console.Clear();
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine($"O número {numero} é par.");
            else
                Console.WriteLine($"O número {numero} é ímpar.");
        }

        static void Atividade7()
        {
            Console.Clear();
            Console.Write("Digite A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite B: ");
            int B = int.Parse(Console.ReadLine());

            int C;
            if (A == B)
            {
                C = A + B;
            }
            else
            {
                C = A * B;
            }
            Console.WriteLine($"O resultado é: {C}");
        }

        static void Atividade8()
        {
            Console.Clear();
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine($"O dobro de {numero} é {numero * 2}.");
            else
                Console.WriteLine($"O triplo de {numero} é {numero * 3}.");
        }

        static void Atividade9()
        {
            Console.Clear();
            Console.WriteLine("Digite 3 valores:");
            int[] valores = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(valores);
            Array.Reverse(valores);
            Console.WriteLine("Valores do maior para o menor: " + string.Join(", ", valores));
        }

        static void Atividade10()
        {
            Console.Clear();
            Console.WriteLine("Digite 3 valores:");
            int[] valores = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(valores);
            Console.WriteLine("Valores do menor para o maior: " + string.Join(", ", valores));
        }

        static void Atividade11()
        {
            Console.Clear();
            Console.Write("Digite a hora de início do jogo (0-23): ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("Digite a hora de fim do jogo (0-23): ");
            int fim = int.Parse(Console.ReadLine());

            int duracao = fim >= inicio ? fim - inicio : (24 - inicio + fim);
            Console.WriteLine($"Duração do jogo: {duracao} horas.");
        }
        static void MenuAtividades3()
        {
            int atividade;

            do
            {
                Console.Clear();
                Console.WriteLine("Atividades da Lista de Exercícios 3:\n");
                Console.WriteLine("1 - Atividade 1 (Soma de 3 valores)");
                Console.WriteLine("2 - Atividade 2 (Média de 4 notas)");
                Console.WriteLine("3 - Atividade 3 (Nome diferente de João)");
                Console.WriteLine("4 - Atividade 4 (Quantidade de números pares entre 35 e 98111)");
                Console.WriteLine("5 - Atividade 5 (Soma de todos os números ímpares de 1 até 5000)");
                Console.WriteLine("6 - Atividade 6 (Tabuada de um número)\n");
                Console.WriteLine("0 - Voltar ao menu principal\n");
                Console.Write("Escolha uma atividade: ");

                atividade = int.Parse(Console.ReadLine());

                switch (atividade)
                {
                    case 1: SomaTresValores(); break;
                    case 2: MediaQuatroNotas(); break;
                    case 3: NomeDiferenteDeJoao(); break;
                    case 4: ContarParesEntre35e98111(); break;
                    case 5: SomaImpares(); break;
                    case 6: Tabuada(); break;
                    case 0: Console.WriteLine("Voltando ao menu principal..."); break;
                    default: Console.WriteLine("Opção inválida. Tente novamente."); break;
                }

                if (atividade != 0)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                }

            } while (atividade != 0);
        }

        
        static void SomaTresValores()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2 + valor3;
            Console.WriteLine($"A soma dos valores é: {soma}");
        }

        
        static void MediaQuatroNotas()
        {
            Console.Clear();
            double total = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Digite a nota {i}: ");
                total += double.Parse(Console.ReadLine());
            }
            double media = total / 4;
            Console.WriteLine($"A média das notas é: {media:F2}");
        }

        
        static void NomeDiferenteDeJoao()
        {
            Console.Clear();
            string nome;
            do
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine();
            } while (nome != "João");

            Console.WriteLine("Você digitou João!");
        }

        
        static void ContarParesEntre35e98111()
        {
            Console.Clear();
            int count = 0;
            for (int i = 36; i <= 98111; i += 2)
            {
                count++;
            }
            Console.WriteLine($"A quantidade de números pares entre 35 e 98111 é: {count}");
        }

        
        static void SomaImpares()
        {
            Console.Clear();
            int soma = 0;
            for (int i = 1; i <= 5000; i += 2)
            {
                soma += i;
            }
            Console.WriteLine($"A soma de todos os números ímpares de 1 até 5000 é: {soma}");
        }

        
        static void Tabuada()
        {
            Console.Clear();
            Console.Write("Digite um número para ver sua tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
            
        }
        static void MenuAtividades4()
        {
            int atividade;

            do
            {
                Console.Clear();
                Console.WriteLine("Atividades da Lista de Exercícios 4:\n");
                Console.WriteLine("1 - Atividade 1 (Verificação de Número Par ou Ímpar)");
                Console.WriteLine("2 - Atividade 2 (Classificação de Idade)");
                Console.WriteLine("3 - Atividade 3 (Verificação de Notas)");
                Console.WriteLine("4 - Atividade 4 (Cálculo de IMC)");
                Console.WriteLine("5 - Atividade 5 (Maior de Dois Números)");
                Console.WriteLine("6 - Atividade 6 (Verificação de Voto)");
                Console.WriteLine("7 - Atividade 7 (Cálculo de Desconto)");
                Console.WriteLine("8 - Atividade 8 (Classificação de Temperatura)");
                Console.WriteLine("9 - Atividade 9 (Cálculo de Média de Três Números)");
                Console.WriteLine("10 - Atividade 10 (Verificação de Ano Bissexto)\n");
                Console.WriteLine("0 - Voltar ao menu principal\n");
                Console.Write("Escolha uma atividade: ");

                atividade = int.Parse(Console.ReadLine());

                switch (atividade)
                {
                    case 1: VerificacaoParOuImpar(); break;
                    case 2: ClassificacaoIdade(); break;
                    case 3: VerificacaoNotas(); break;
                    case 4: CalculoIMC(); break;
                    case 5: MaiorDeDoisNumeros(); break;
                    case 6: VerificacaoVoto(); break;
                    case 7: CalculoDesconto(); break;
                    case 8: ClassificacaoTemperatura(); break;
                    case 9: CalculoMediaTresNumeros(); break;
                    case 10: VerificacaoAnoBissexto(); break;
                    case 0: Console.WriteLine("Voltando ao menu principal..."); break;
                    default: Console.WriteLine("Opção inválida. Tente novamente."); break;
                }

                if (atividade != 0)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                }

            } while (atividade != 0);
        }

        static void VerificacaoParOuImpar()
        {
            Console.Clear();
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            string resultado = (numero % 2 == 0) ? "par" : "ímpar";
            Console.WriteLine($"O número {numero} é {resultado}.");
        }

        static void ClassificacaoIdade()
        {
            Console.Clear();
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 12)
                Console.WriteLine("Você é uma Criança.");
            else if (idade >= 13 && idade <= 17)
                Console.WriteLine("Você é um Adolescente.");
            else if (idade >= 18 && idade <= 64)
                Console.WriteLine("Você é um Adulto.");
            else
                Console.WriteLine("Você é um Idoso.");
        }

        static void VerificacaoNotas()
        {
            Console.Clear();
            Console.Write("Digite a nota (0 a 10): ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 6)
                Console.WriteLine("Aprovado");
            else if (nota >= 4)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");
        }

        static void CalculoIMC()
        {
            Console.Clear();
            Console.Write("Digite seu peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            string categoria;

            if (imc < 18.5)
                categoria = "Abaixo do peso";
            else if (imc < 24.9)
                categoria = "Peso normal";
            else if (imc < 29.9)
                categoria = "Sobrepeso";
            else
                categoria = "Obesidade";

            Console.WriteLine($"Seu IMC é {imc:F2} e você está classificado como: {categoria}");
        }

        static void MaiorDeDoisNumeros()
        {
            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine($"O maior número é: {num1}");
            else if (num2 > num1)
                Console.WriteLine($"O maior número é: {num2}");
            else
                Console.WriteLine("Os números são iguais.");
        }

        static void VerificacaoVoto()
        {
            Console.Clear();
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 16)
                Console.WriteLine("Você não pode votar.");
            else if (idade <= 17 || idade > 70)
                Console.WriteLine("Voto facultativo.");
            else
                Console.WriteLine("Você é obrigado a votar.");
        }

        static void CalculoDesconto()
        {
            Console.Clear();
            Console.Write("Digite o valor da compra: R$ ");
            double valor = double.Parse(Console.ReadLine());

            if (valor > 100)
            {
                double desconto = valor * 0.10;
                double valorFinal = valor - desconto;
                Console.WriteLine($"Desconto de R$ {desconto:F2} aplicado. Valor final: R$ {valorFinal:F2}");
            }
            else
            {
                Console.WriteLine("Nenhum desconto aplicado. Valor total: R$ " + valor);
            }
        }

        static void ClassificacaoTemperatura()
        {
            Console.Clear();
            Console.Write("Digite a temperatura em graus Celsius: ");
            double temperatura = double.Parse(Console.ReadLine());

            if (temperatura < 15)
                Console.WriteLine("Está Frio.");
            else if (temperatura <= 25)
                Console.WriteLine("Está Agradável.");
            else
                Console.WriteLine("Está Quente.");
        }

        static void CalculoMediaTresNumeros()
        {
            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            double num3 = double.Parse(Console.ReadLine());

            double media = (num1 + num2 + num3) / 3;
            Console.WriteLine($"A média é: {media:F2}. Você está " + (media > 7 ? "Aprovado" : "Reprovado"));
        }

        static void VerificacaoAnoBissexto()
        {
            Console.Clear();
            Console.Write("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            bool isBissexto = (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
            if (isBissexto)
                Console.WriteLine($"{ano} é um ano bissexto.");
            else
                Console.WriteLine($"{ano} não é um ano bissexto.");
        }
    }


}
        
    

    


    

