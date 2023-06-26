


using System.Security.Cryptography.X509Certificates;
using SegundaListaP3.cs;

class Principal
{

    public static void Main(string[] args)
    {
        int opcao;

        do
        {



            

            Console.WriteLine("=========================================");
            Console.WriteLine("|35 - Multiplosde 10 em 100               |");
            Console.WriteLine("|36 - Maior Menor Valor e Positivo        |");
            Console.WriteLine("|37 _ Quatro Operações                    |");
            Console.WriteLine("|38 - CalculoSalario                      |");
            Console.WriteLine("|39 -  Par impar positivo e negativo      |");
            Console.WriteLine("|40 - Indice Poluição                     |");
            Console.WriteLine("|41 - Classificação Categorica            |");
            Console.WriteLine("|42 - Maior Menor De Nnumeros             |");
            Console.WriteLine("|43 - NumeroDeGraosPagamento              |");
            Console.WriteLine("|44 - Escolher entre 4 Opções             |");
            Console.WriteLine("|45 - Numeros Na Orde Inversa             |");
            Console.WriteLine("|46 - Produto Escalar Vetores             |");
            Console.WriteLine("|47 - Numeros Maiores Menores e Iguais a X|");
            Console.WriteLine("|48 - Encontrar Modelo                    |");
            Console.WriteLine("|49 - Valores Iguais Na Mesma Posicao     |");
            Console.WriteLine("|50 - Adivinhe  o Numero                  |");
            Console.WriteLine("|51 - Notas Acima De da media             |");
            Console.WriteLine("|52 - Vezes Que Numero Aparece            |");
            Console.WriteLine("|53 - Corrida Automoveis                  |");
            Console.WriteLine("|54 - Elementos Comuns nos Vetores        |");
            Console.WriteLine("|55 - Retirar  Espacos em Branco          |");
            Console.WriteLine("|56 - Numeros Pares Emultiplos De 5       |");
            Console.WriteLine("|57 - Imprimir Somente as Vogais          |");
            Console.WriteLine("|58 - Elementos Comuns nos Vetores        |");
            Console.WriteLine("|59 - Contar Caracteres                   |");
            Console.WriteLine("|61-  Calculo   Reajuste                  |");
            Console.WriteLine("|62 - Calculo  Hipotenusa                 |");
            Console.WriteLine("|63 - Verificar se é Parou Impar          |");
            Console.WriteLine("|0 - Sair                                 |");
            Console.WriteLine("=========================================");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {

                case 35:
                    ExerciciosP3 exerc35 = new ExerciciosP3();
                    exerc35.Multiplosde10Em100();


                    break;

                case 36:
                    ExerciciosP3 exerc36 = new ExerciciosP3();
                    exerc36.MaiorMenorValorNumPositivo();
                    break;

                case 37:
                    ExerciciosP3 exerc37 = new ExerciciosP3();
                    exerc37.QuatroOperacoes();
                    break;

                case 38:
                    ExerciciosP3 exerc38 = new ExerciciosP3();
                    exerc38.CalculoSalario();

                    break;
                case 39:
                    ExerciciosP3 exerc39 = new ExerciciosP3();
                    exerc39.ParImparPositivoNegativo();

                    break;
                case 40:
                    ExerciciosP3 exerc40 = new ExerciciosP3();
                    exerc40.IndicePoluicao();

                    break;
                case 41:
                    ExerciciosP3 exerc41 = new ExerciciosP3();
                    exerc41.ClassificacaoCategorica();
                    break;
                case 42:
                    ExerciciosP3 exerc42 = new ExerciciosP3();
                    exerc42.MaiorMenorDeNnumeros();
                    break;
                case 43:
                    ExerciciosP3 exerc43 = new ExerciciosP3();
                    exerc43.NumeroDeGraosPagamento();

                    break;
                case 44:
                    ExerciciosP3 exerc44 = new ExerciciosP3();
                    exerc44.Escolherentre4Opcoes();

                    break;

                case 45:
                    ExerciciosP3 exerc45 = new ExerciciosP3();
                    exerc45.NumerosNaORdeInversa();

                    break;
                case 46:
                    ExerciciosP3 exerc46 = new ExerciciosP3();
                    exerc46.ProdutoEscalarVetores();



                    break;
                case 47:
                    ExerciciosP3 exerc47 = new ExerciciosP3();
                    exerc47.NumerosMaioresMenoresIguaisaX();

                    break;
                case 48:
                    ExerciciosP3 exerc48 = new ExerciciosP3();
                    exerc48.EncontrarModelo();

                    break;
                case 49:
                    ExerciciosP3 exerc49 = new ExerciciosP3();
                    exerc49.ValoresIguaisNaMesmaPosicao();


                    break;
                case 50:
                    ExerciciosP3 exerc50 = new ExerciciosP3();
                    exerc50.AdivinheoNumero();


                    break;
                case 51:
                    ExerciciosP3 exerc51 = new ExerciciosP3();
                    exerc51.NotasAcimaDeCinco();


                    break;
                case 52:
                    ExerciciosP3 exerc52 = new ExerciciosP3();
                    exerc52.VezesQueNumeroAparece();


                    break;
                case 53:
                    ExerciciosP3 exerc53 = new ExerciciosP3();
                    exerc53.CorridaAutomoveis();


                    break;
                case 54:
                    ExerciciosP3 exerc54 = new ExerciciosP3();
                    exerc54.ElementosComunsVetores();
                    break;

                case 55:
                    ExerciciosP3 exerc55 = new ExerciciosP3();
                    exerc55.RetirarEspacos();

                    break;

                case 56:
                    ExerciciosP3 exerc56 = new ExerciciosP3();
                    exerc56.NumerosParesEmultiplosDe5();

                    break;
                case 57:
                    ExerciciosP3 exerc57 = new ExerciciosP3();
                    exerc57.ImprimirSomenteVogais();


                    break;

                case 58:
                    ExerciciosP3 exerc58 = new ExerciciosP3();
                    exerc58.MediaeMaiorValor();

                    break;
                case 59:
                    ExerciciosP3 exerc59 = new ExerciciosP3();
                    exerc59.ContCaracteres();

                    break;

                case 61:
                    ExerciciosP3 exerc61 = new ExerciciosP3();
                    exerc61.CalculoReajuste();

                    break;
                case 62:
                    ExerciciosP3 exerc62 = new ExerciciosP3();
                    exerc62.CalculoHipotenusa();


                    break;
                case 63:
                    ExerciciosP3 exerc63 = new ExerciciosP3();
                    exerc63.VerificarParouImpar();


                    break;

                case 0:

                    Console.WriteLine("Sair!");
                    break;

                default:

                    Console.WriteLine("Opção Invalida!");
                    break;









            }
        } while (opcao!=0);

    }



}