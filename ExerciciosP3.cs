using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaListaP3.cs
{
    internal class ExerciciosP3
    {

        public  void Multiplosde10Em100()
        {
            //35

            int cont = 0, num;


            
            do
            {
                cont++;
                if (cont % 10 == 0)
                {

                    num = cont;
                    Console.WriteLine(num+" É multiplo de 10: ");

                }

            } while (cont <100);

            



        }

        public void MaiorMenorValorNumPositivo()
        {
            //36

                const int quantidadeValores = 10;
                int[] valores = new int[quantidadeValores];

                // Leitura dos valores
                for (int i = 0; i < quantidadeValores; i++)
                {
                    Console.Write($"Digite o {i + 1}º valor: ");
                    valores[i] = int.Parse(Console.ReadLine());
                }

                // Encontrar o maior valor
                int maiorValor = int.MinValue;
                foreach (int valor in valores)
                {
                    if (valor > maiorValor)
                        maiorValor = valor;
                }

                // Encontrar o menor valor
                int menorValor = int.MaxValue;
                foreach (int valor in valores)
                {
                    if (valor < menorValor)
                        menorValor = valor;
                }

                // Calcular a média dos valores
                int soma = 0;
                foreach (int valor in valores)
                {
                    soma += valor;
                }
                double media = (double)soma / quantidadeValores;

                // Exibir resultados
                Console.WriteLine($"Maior valor: {maiorValor}");
                Console.WriteLine($"Menor valor: {menorValor}");
                Console.WriteLine($"Média dos valores: {media}");
            
        


        }


        public void QuatroOperacoes()
        {
            //37
            


                bool shouldExit = false;

                while (!shouldExit)
                {
                    Console.WriteLine("Opções:");
                    Console.WriteLine("1 - Adição");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("5 - Sair");
                    Console.Write("Informe a opção: ");

                    int option;
                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                        continue;
                    }

                    switch (option)
                    {
                        case 1:
                            PerformAddition();
                            break;
                        case 2:
                            PerformSubtraction();
                            break;
                        case 3:
                            PerformMultiplication();
                            break;
                        case 4:
                            PerformDivision();
                            break;
                        case 5:
                            shouldExit = true;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                            break;
                    }

                    if (!shouldExit)
                    {
                        Console.Write("Deseja voltar ao menu principal? (S/N): ");
                        string answer = Console.ReadLine();

                        if (answer.Equals("N", StringComparison.OrdinalIgnoreCase))
                        {
                            shouldExit = true;
                        }

                        Console.WriteLine();
                    }
                }
            

            static void PerformAddition()
            {
                Console.WriteLine("Opção de adição selecionada.");
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 + num2;
                Console.WriteLine($"Resultado da adição: {result}");
                Console.WriteLine();
            }

            static void PerformSubtraction()
            {
                Console.WriteLine("Opção de subtração selecionada.");
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 - num2;
                Console.WriteLine($"Resultado da subtração: {result}");
                Console.WriteLine();
            }

            static void PerformMultiplication()
            {
                Console.WriteLine("Opção de multiplicação selecionada.");
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 * num2;
                Console.WriteLine($"Resultado da multiplicação: {result}");
                Console.WriteLine();
            }

            static void PerformDivision()
            {
                Console.WriteLine("Opção de divisão selecionada.");
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 != 0)
                {
                    double result = (double)num1 / num2;
                    Console.WriteLine($"Resultado da divisão: {result}");
                }
                else
                {
                    Console.WriteLine("Erro: divisão por zero!");
                }

                Console.WriteLine();
            }
        


        }

        public void CalculoSalario()
        {
            //38


           


                while (true)
                {
                    Console.Write("Digite o código do operário (C): ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o número de horas trabalhadas (N): ");
                    int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

                    double salarioTotal;
                    double salarioExcedente;

                    if (horasTrabalhadas > 50)
                    {
                        int horasExcedentes = horasTrabalhadas - 50;
                        salarioTotal = 50 * 10 + horasExcedentes * 20;
                        salarioExcedente = horasExcedentes * 20;
                    }
                    else
                    {
                        salarioTotal = horasTrabalhadas * 10;
                        salarioExcedente = 0;
                    }

                    Console.WriteLine("Salário total: R$ " + salarioTotal.ToString("F2"));
                    Console.WriteLine("Salário excedente: R$ " + salarioExcedente.ToString("F2"));

                    Console.WriteLine("Deseja encerrar o programa? (S/N)");
                    string resposta = Console.ReadLine();

                    if (resposta.ToUpper() == "S")
                        break;

                    Console.WriteLine();
                }
            
        

        }


        public void ParImparPositivoNegativo()
        {
            //39
            
            
              string encerrar = "N";

                while (encerrar != "S")
                {
                    Console.Write("Digite um número inteiro: ");
                    int num = int.Parse(Console.ReadLine());

                    string parImpar = (num % 2 == 0) ? "par" : "ímpar";
                    string positivoNegativo = (num >= 0) ? "positivo" : "negativo";

                    Console.WriteLine($"O número {num} é {parImpar} e {positivoNegativo}.");

                    Console.Write("Deseja encerrar o programa? (S/N): ");
                    encerrar = Console.ReadLine().ToUpper();
                }
            
        


        }

        public void IndicePoluicao()
        {
            //40


           


                double indiceP;

                do
                {
                    Console.Write("Digite o índice de poluição medido: ");
                    indiceP = Convert.ToDouble(Console.ReadLine());

                    if (indiceP >= 0.05 && indiceP <= 0.25)
                    {
                        Console.WriteLine("Índice de poluição dentro do limite aceitável.");
                    }
                    else if (indiceP > 0.25 && indiceP <= 0.3)
                    {
                        Console.WriteLine("Índice de poluição acima do limite aceitável.");
                        Console.WriteLine("Indústrias do 1º grupo devem suspender suas atividades.");
                    }
                    else if (indiceP> 0.3 && indiceP <= 0.4)
                    {
                        Console.WriteLine("Índice de poluição acima do limite aceitável.");
                        Console.WriteLine("Indústrias do 1º e 2º grupos devem suspender suas atividades.");
                    }
                    else if (indiceP > 0.4 && indiceP <= 0.5)
                    {
                        Console.WriteLine("Índice de poluição acima do limite aceitável.");
                        Console.WriteLine("Todas as indústrias devem suspender suas atividades.");
                    }
                    else if (indiceP > 0.5)
                    {
                        Console.WriteLine("Índice de poluição crítico.");
                        Console.WriteLine("Todas as indústrias devem suspender suas atividades imediatamente.");
                    }

                    Console.Write("Deseja encerrar o programa? (S) (N): ");
                } while (Console.ReadLine().ToUpper() != "S");
            
        


        }

        public void ClassificacaoCategorica()
        {

            //41

           

           
                Console.WriteLine("Informe a idade do nadador:");
                int idade = Convert.ToInt32(Console.ReadLine());

                string categoria;

                if (idade >= 5 && idade <= 7)
                {
                    categoria = "Infantil A";
                }
                else if (idade >= 8 && idade <= 11)
                {
                    categoria = "Infantil B";
                }
                else if (idade >= 12 && idade <= 13)
                {
                    categoria = "Juvenil A";
                }
                else if (idade >= 14 && idade <= 17)
                {
                    categoria = "Juvenil B";
                }
                else if (idade >= 18)
                {
                    categoria = "Adultos";
                }
                else
                {
                    categoria = "Idade inválida para competir.";
                }

                Console.WriteLine("O nadador está na categoria: " + categoria);
            
        


        }

        public void MaiorMenorDeNnumeros()
        {
            //42

            

                int maiorNum = int.MinValue;
                int menorNum = int.MaxValue;

                Console.WriteLine("Digite os números (0 para sair):");

                while (true)
                {
                    int numero = int.Parse(Console.ReadLine());

                    if (numero == 0)
                        break;

                    if (numero > maiorNum)
                        maiorNum = numero;

                    if (numero < menorNum)
                        menorNum = numero;
                }

                Console.WriteLine("Maior número: " + maiorNum);
                Console.WriteLine("Menor número: " + menorNum);

                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
            
        


        }
        public void NumeroDeGraosPagamento()
        {
            //43
           


           
                int numQuadros = 64; // número total de quadros no tabuleiro
                long totalGraos = CalcularTotalGraos(numQuadros);

                Console.WriteLine("O número total de grãos que o monge esperava receber é: " + totalGraos);
            

            static long CalcularTotalGraos(int numQuadros)
            {
                long totalGraos = 0;
                long graosQuadroAnterior = 1;

                for (int i = 1; i <= numQuadros; i++)
                {
                    totalGraos += graosQuadroAnterior;
                    graosQuadroAnterior *= 2;
                }

                return totalGraos;
            }
        


        }

        public void Escolherentre4Opcoes()
        {
            //44

            


                string encerrar = "N";

                do
                {
                    Console.WriteLine("Escolha uma opção:");
                    Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                    Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                    Console.WriteLine("3 - Peso ideal do homem");
                    Console.WriteLine("4 - Peso ideal da mulher");
                    Console.WriteLine("S - Encerrar o programa");

                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            ConversaoCelsiusParaFahrenheit();
                            break;
                        case "2":
                            ConversaoFahrenheitParaCelsius();
                            break;
                        case "3":
                            PesoIdealHomem();
                            break;
                        case "4":
                            PesoIdealMulher();
                            break;
                        case "S":
                        case "s":
                            encerrar = "S";
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }

                    Console.WriteLine("Deseja encerrar o programa? (S/N)");
                    encerrar = Console.ReadLine();
                } while (encerrar != "S" && encerrar != "s");
            

            static void ConversaoCelsiusParaFahrenheit()
            {
                Console.WriteLine("Digite a temperatura em graus Celsius:");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit);
            }

            static void ConversaoFahrenheitParaCelsius()
            {
                Console.WriteLine("Digite a temperatura em graus Fahrenheit:");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine("A temperatura em graus Celsius é: " + celsius);
            }

            static void PesoIdealHomem()
            {
                Console.WriteLine("Digite a altura em metros:");
                double altura = Convert.ToDouble(Console.ReadLine());
                double pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("O peso ideal para um homem com essa altura é: " + pesoIdeal);

                Console.WriteLine("Digite o peso atual em kg:");
                double pesoAtual = Convert.ToDouble(Console.ReadLine());
                if (pesoAtual < pesoIdeal)
                {
                    Console.WriteLine("Você está abaixo do peso ideal.");
                }
                else if (pesoAtual > pesoIdeal)
                {
                    Console.WriteLine("Você está acima do peso ideal.");
                }
                else
                {
                    Console.WriteLine("Você está no peso ideal.");
                }
            }

            static void PesoIdealMulher()
            {
                Console.WriteLine("Digite a altura em metros:");
                double altura = Convert.ToDouble(Console.ReadLine());
                double pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("O peso ideal para uma mulher com essa altura é: " + pesoIdeal);

                Console.WriteLine("Digite o peso atual em kg:");
                double pesoAtual = Convert.ToDouble(Console.ReadLine());
                if (pesoAtual < pesoIdeal)
                {
                    Console.WriteLine("Você está abaixo do peso ideal.");
                }
                else if (pesoAtual > pesoIdeal)
                {
                    Console.WriteLine("Você está acima do peso ideal.");
                }
                else
                {
                    Console.WriteLine("Você está no peso ideal.");
                }
            }
        


        }

        public void NumerosNaORdeInversa()
        {
            //45

            

                Console.Write("Digite o tamanho da sequência de números: ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] numeros = new int[tamanho];

                Console.WriteLine("Digite os números:");

                // Ler os números
                for (int i = 0; i < tamanho; i++)
                {
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Sequência invertida:");

                // Imprimir os números na ordem inversa
                for (int i = tamanho - 1; i >= 0; i--)
                {
                    Console.WriteLine(numeros[i]);
                }
            
        


        }
        public void ProdutoEscalarVetores() 
        {
            //46

           


                Console.WriteLine("Informe o tamanho dos vetores:");
                int n = int.Parse(Console.ReadLine());

                int[] vetorX = new int[n];
                int[] vetorY = new int[n];

                Console.WriteLine("Informe os elementos do vetor X:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Elemento {i + 1}: ");
                    vetorX[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Informe os elementos do vetor Y:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Elemento {i + 1}: ");
                    vetorY[i] = int.Parse(Console.ReadLine());
                }

                int produtoEscalar = CalcularProdutoEscalar(vetorX, vetorY);
                Console.WriteLine($"O produto escalar dos vetores X e Y é: {produtoEscalar}");
            

            static int CalcularProdutoEscalar(int[] vetorX, int[] vetorY)
            {
                int produtoEscalar = 0;
                for (int i = 0; i < vetorX.Length; i++)
                {
                    produtoEscalar += vetorX[i] * vetorY[i];
                }
                return produtoEscalar;
            }
        





        }
        public void NumerosMaioresMenoresIguaisaX()
        {
            //47
            


                int[] vetor = new int[10];
                int x;

                Console.WriteLine("Digite os 10 números inteiros positivos maiores que zero:");
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Digite um número inteiro positivo maior que zero: ");
                x = int.Parse(Console.ReadLine());

                int maioresQueX = 0;
                int menoresQueX = 0;
                int iguaisAX = 0;

                foreach (int num in vetor)
                {
                    if (num > x)
                        maioresQueX++;
                    else if (num < x)
                        menoresQueX++;
                    else
                        iguaisAX++;
                }

                Console.WriteLine($"Quantidade de números maiores que {x}: {maioresQueX}");
                Console.WriteLine($"Quantidade de números menores que {x}: {menoresQueX}");
                Console.WriteLine($"Quantidade de números iguais a {x}: {iguaisAX}");

                Console.ReadLine();
            
        


        }

        public void EncontrarModelo()
        {
            //48

          


                string[] nomes = new string[20];
                int[] idades = new int[20];

                // Preencha os vetores com os dados das candidatas
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Digite o nome da candidata {0}: ", i + 1);
                    nomes[i] = Console.ReadLine();

                    Console.Write("Digite a idade da candidata {0}: ", i + 1);
                    idades[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nCandidatas aptas para a campanha publicitária:\n");

                // Verifique as candidatas aptas e imprima seus nomes
                for (int i = 0; i < 20; i++)
                {
                    if (idades[i] >= 18 && idades[i] <= 20)
                    {
                        Console.WriteLine(nomes[i]);
                    }
                }
            
        


        }

        public void ValoresIguaisNaMesmaPosicao()
        {
            //49


          


                Console.Write("Digite o tamanho dos vetores (no máximo 50): ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] v1 = new int[tamanho];
                int[] v2 = new int[tamanho];

                // Leitura dos valores do vetor V1
                Console.WriteLine("Digite os valores do vetor V1:");
                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write($"V1[{i}]: ");
                    v1[i] = int.Parse(Console.ReadLine());
                }

                // Leitura dos valores do vetor V2
                Console.WriteLine("Digite os valores do vetor V2:");
                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write($"V2[{i}]: ");
                    v2[i] = int.Parse(Console.ReadLine());
                }

                // Contagem de valores idênticos nas mesmas posições
                int count = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    if (v1[i] == v2[i])
                    {
                        count++;
                    }
                }

                // Impressão do resultado
                Console.WriteLine($"V1 e V2 possuem {count} valores idênticos nas mesmas posições.");
            
        


        }

        public void AdivinheoNumero()
        {
            //50

           


                Random random = new Random();
                int numSorteado = random.Next(0, 101);
                int tentativas = 0;
                int tentativa;

                Console.WriteLine("Bem-vindo ao jogo de adivinhação!");

                do
                {
                    Console.Write("Digite um número entre 0 e 100: ");
                    tentativa = Convert.ToInt32(Console.ReadLine());
                    tentativas++;

                    if (tentativa < numSorteado)
                    {
                        Console.WriteLine("O número sorteado é maior que {0}.", tentativa);
                    }
                    else if (tentativa > numSorteado)
                    {
                        Console.WriteLine("O número sorteado é menor que {0}.", tentativa);
                    }
                    else
                    {
                        Console.WriteLine("Parabéns! Você acertou o número sorteado em {0} tentativa(s).", tentativas);
                    }
                } while (tentativa != numSorteado);

                Console.WriteLine("Obrigado por jogar!");
            
        


        }

        public void NotasAcimaDeCinco()
        {
            //51


           


                Console.Write("Informe a quantidade de alunos: ");
                int quantAlunos = int.Parse(Console.ReadLine());

                double somaNotas = 0;
                int contNotasAcimaSete = 0;

                for (int i = 1; i <= quantAlunos; i++)
                {
                    Console.Write($"Informe a nota do aluno {i}: ");
                    double nota = double.Parse(Console.ReadLine());

                    somaNotas += nota;

                    if (nota > 7.0)
                    {
                        contNotasAcimaSete++;
                    }
                }

                double media = somaNotas / quantAlunos;

                Console.WriteLine($"Média aritmética das notas: {media}");

                if (contNotasAcimaSete > 0)
                {
                    Console.WriteLine($"Quantidade de alunos com nota acima de 7.0: {contNotasAcimaSete}");
                }
                else
                {
                    Console.WriteLine("Não há nenhum aluno com nota acima de 7.0.");
                }
            
        


        }

        public void VezesQueNumeroAparece()
        {
            //52

            


                const int MAX_SIZE = 100;
                int[] vetor = new int[MAX_SIZE];
                int tamanho = 0;

                Console.WriteLine("Digite os números inteiros e positivos (ou -1 para sair):");

                // Leitura dos números até o máximo de posições do vetor ou até ser digitado -1
                for (int i = 0; i < MAX_SIZE; i++)
                {
                    int numero = int.Parse(Console.ReadLine());

                    if (numero == -1)
                        break;

                    vetor[i] = numero;
                    tamanho++;
                }

                // Contagem dos números 1, 3 e 4
                int contador1 = 0;
                int contador3 = 0;
                int contador4 = 0;

                for (int i = 0; i < tamanho; i++)
                {
                    if (vetor[i] == 1)
                        contador1++;
                    else if (vetor[i] == 3)
                        contador3++;
                    else if (vetor[i] == 4)
                        contador4++;
                }

                // Impressão dos resultados
                Console.WriteLine("Quantidade de vezes que o número 1 aparece: " + contador1);
                Console.WriteLine("Quantidade de vezes que o número 3 aparece: " + contador3);
                Console.WriteLine("Quantidade de vezes que o número 4 aparece: " + contador4);
            
        


        }

        public void CorridaAutomoveis()
        {
            //53

           


           
                Console.Write("Digite a quantidade de voltas: ");
                int n = int.Parse(Console.ReadLine());

                double[] tempos = new double[n];

                // Ler os tempos das voltas
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Digite o tempo da volta {i + 1}: ");
                    tempos[i] = double.Parse(Console.ReadLine());
                }

                // Calcular o melhor tempo
                double melhorTempo = tempos[0];
                int voltaMelhorTempo = 1;

                for (int i = 1; i < n; i++)
                {
                    if (tempos[i] < melhorTempo)
                    {
                        melhorTempo = tempos[i];
                        voltaMelhorTempo = i + 1;
                    }
                }

                // Calcular o tempo médio
                double somaTempos = 0;
                for (int i = 0; i < n; i++)
                {
                    somaTempos += tempos[i];
                }

                double tempoMedio = somaTempos / n;

                // Imprimir os resultados
                Console.WriteLine($"Melhor tempo: {melhorTempo}");
                Console.WriteLine($"Volta do melhor tempo: {voltaMelhorTempo}");
                Console.WriteLine($"Tempo médio: {tempoMedio}");
            
        

        }

        public void ElementosComunsVetores()
        {
            //54

           

                int[] vetorA = { 2, 4, 3, 4, 5 };
                int[] vetorB = { 4, 5, 6, 7, 8, 9, 10, 12 };

                EncontrarElementosComuns(vetorA, vetorB);
            

            static void EncontrarElementosComuns(int[] vetorA, int[] vetorB)
            {
                Console.WriteLine("Elementos comuns entre os dois vetores:");

                foreach (int elementoA in vetorA)
                {
                    foreach (int elementoB in vetorB)
                    {
                        if (elementoA == elementoB)
                        {
                            Console.WriteLine(elementoA);
                            break;
                        }
                    }
                }
            }
        


        }

        public void RetirarEspacos()
        {
            //55

            


            
                Console.Write("Digite uma frase de até 50 caracteres: ");
                string frase = Console.ReadLine();

                // Remover os espaços em branco da frase
                string fraseSemEspacos = frase.Replace(" ", "");

                Console.WriteLine("Frase sem espaços em branco: " + fraseSemEspacos);
                Console.WriteLine("Quantidade de espaços em branco: " + (frase.Length - fraseSemEspacos.Length));
            
        


        }

        public void NumerosParesEmultiplosDe5()
        {
            //56
            


          
                int[] vetor = new int[50];
                int quantidadePares = 0;
                int quantidadeMultiplosDe5 = 0;

                Console.WriteLine("Digite os números do vetor:");

                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.Write($"Posição {i + 1}: ");
                    vetor[i] = int.Parse(Console.ReadLine());

                    if (vetor[i] % 2 == 0)
                        quantidadePares++;

                    if (vetor[i] % 5 == 0)
                        quantidadeMultiplosDe5++;
                }

                Console.WriteLine($"Quantidade de números pares: {quantidadePares}");
                Console.WriteLine($"Quantidade de múltiplos de 5: {quantidadeMultiplosDe5}");

                Console.ReadLine();
            
        

        }

        public void ImprimirSomenteVogais()
        {
            //57

            


                Console.WriteLine("Digite uma frase:");
                string frase = Console.ReadLine();

                Console.WriteLine("Vogais encontradas na frase:");
                foreach (char c in frase)
                {
                    if (IsVowel(c))
                    {
                        Console.Write(c);
                    }
                }

                Console.ReadLine();
            

            static bool IsVowel(char c)
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                return Array.IndexOf(vowels, c) != -1;
            }
        

        }

        public void MediaeMaiorValor()
        {
            //58

           


                Console.Write("Informe a quantidade de números a serem lidos: ");
                int quantidade = int.Parse(Console.ReadLine());

                int[] numeros = new int[quantidade];

                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write($"Informe o {i + 1}º número: ");
                    numeros[i] = int.Parse(Console.ReadLine());

                    while (numeros[i] <= 0)
                    {
                        Console.Write("O número deve ser positivo. Informe novamente: ");
                        numeros[i] = int.Parse(Console.ReadLine());
                    }
                }

                int soma = 0;
                int maior = numeros[0];

                for (int i = 0; i < quantidade; i++)
                {
                    soma += numeros[i];

                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }
                }

                double media = (double)soma / quantidade;

                Console.WriteLine($"Média: {media}");
                Console.WriteLine($"Maior valor: {maior}");

                Console.ReadLine();
            
        

        }

        public void ContCaracteres()
        {
            //59

           

                Console.Write("Digite o primeiro caractere (A-Z): ");
                char primeiroCaractere = Console.ReadLine().ToUpper()[0];

                Console.Write("Digite o segundo caractere (A-Z): ");
                char segundoCaractere = Console.ReadLine().ToUpper()[0];

                if (primeiroCaractere >= 'A' && primeiroCaractere <= 'Z' &&
                    segundoCaractere >= 'A' && segundoCaractere <= 'Z')
                {
                    if (primeiroCaractere <= segundoCaractere)
                    {
                        int numeroCaracteres = segundoCaractere - primeiroCaractere - 1;
                        Console.WriteLine("O número de caracteres entre eles é: " + numeroCaracteres);
                    }
                    else
                    {
                        Console.WriteLine("Os caracteres não estão em ordem alfabética.");
                    }
                }
                else
                {
                    Console.WriteLine("Digite caracteres válidos (A-Z).");
                }
            
        

        }

        public void CalculoReajuste()
        {

            //61

           


                Console.Write("Digite o valor do salário: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("Digite o índice de reajuste (em decimal): ");
                double indice = double.Parse(Console.ReadLine());

                double salarioAtualizado = Reajuste(salario, indice);

                Console.WriteLine($"Salário atualizado: {salarioAtualizado:C2}");
            

            static double Reajuste(double salario, double indice)
            {
                return salario + (salario * indice);
            }
        


        }

        public void CalculoHipotenusa()
        {
            //62

            


           
                Console.Write("Digite o valor da base do triângulo: ");
                double baseTriangulo = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor da altura do triângulo: ");
                double alturaTriangulo = double.Parse(Console.ReadLine());

                double hipotenusa = CalcularHipotenusa(baseTriangulo, alturaTriangulo);
                Console.WriteLine("A hipotenusa do triângulo é: " + hipotenusa);

                double area = CalcularArea(baseTriangulo, alturaTriangulo);
                Console.WriteLine("A área do triângulo é: " + area);
            

            static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
            {
                double hipotenusaQuadrado = Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2);
                double hipotenusa = Math.Sqrt(hipotenusaQuadrado);
                return hipotenusa;
            }

            static double CalcularArea(double baseTriangulo, double alturaTriangulo)
            {
                double area = (baseTriangulo * alturaTriangulo) / 2;
                return area;
            }
        

        }

        public void VerificarParouImpar()
        {
            //63

           

           
                Console.WriteLine("Digite um número inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                string resultado = Verifica(numero);
                Console.WriteLine(resultado);
            

            static string Verifica(int n)
            {
                if (n % 2 == 0)
                {
                    return "PAR";
                }
                else
                {
                    return "ÍMPAR";
                }
            }
        


        }


        
































































































































































































}
}
