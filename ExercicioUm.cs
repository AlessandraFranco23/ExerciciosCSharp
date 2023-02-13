using System;

namespace listas
{
    public class ExercicioUm
    {
        public static void call()
        {
            Console.WriteLine("=== EXERCÍCIOS - LISTA 1 ===");

            Console.WriteLine("+-------------------------------------------------------+");
            Console.WriteLine("| 1 - Calcule a Média                                   |");
            Console.WriteLine("| 2 - Calcule a Área                                    |");
            Console.WriteLine("| 3 - Calcule o Volume                                  |");
            Console.WriteLine("| 4 - Valor é maior que o dobro de outro valor          |");
            Console.WriteLine("| 5 - Cálculo de Bhaskara                               |");
            Console.WriteLine("| 6 - Velocidade Média                                  |");
            Console.WriteLine("| 7 - Percentual de Imposto                             |");
            Console.WriteLine("| 8 - Valor é par ou ímpar                              |");
            Console.WriteLine("| 9 - Comparar dois valores de String                   |");
            Console.WriteLine("| 10 - Valor double em string e convertido para inteiro |");
            Console.WriteLine("| 11 - Imposto de renda de um salário                   |");
            Console.WriteLine("| 12 - DESAFIO                                          |");
            Console.WriteLine("+-------------------------------------------------------+");

            //int menu = 0;
            int menu = Int32.Parse(Console.ReadLine());
            do
            {
            switch (menu) 
            {
                case 1:
                    double valorMedia = media(5, 7, 10);
                    Console.WriteLine("A média dos números é: " + valorMedia);
                    break;
                case 2:
                    double valorArea = area (5,3);
                    Console.WriteLine("A área: " + valorArea);
                    break;
                case 3:
                    double valorVolume = volume (2,6,5);
                    Console.WriteLine("O volume é: " + valorVolume);
                    break;
                case 4:
                    bool valorDobro = valorMaiorQueDobro(4, 9);
                    Console.WriteLine("O valor é maior? " + valorDobro);
                    break;
                case 5:
                    double[] valorBhaskara = bhaskara(1, 4, 1);
                    Console.WriteLine("O resultado é: " + valorBhaskara);
                    break;
                case 6:
                    double valorMediaViagem = mediaViagem(22, 2);
                    Console.WriteLine("A media da viagem é: " + valorMediaViagem);
                    break;
                case 7:
                    double valorPercentualImposto = percentualImposto(2000, 22);
                    Console.WriteLine("O percentual de imposto é: " + valorPercentualImposto);
                    break;
                case 8:
                    bool valorParouImpar = parOuImpar(4);
                    Console.WriteLine("O valor é: " + valorParouImpar);
                    break;
                case 9:
                    bool valorCompareString = compareString("a","a");
                    Console.WriteLine("É igual: " + valorCompareString);
                    break;
                case 10:
                    int valorConvertString = convertString(2.2);
                    Console.WriteLine("O valor é: " + valorConvertString);
                    break;
                case 11:
                    double valorPercentualImpostoSalario = percentualImpostoSalario(2000);
                    Console.WriteLine("O perental do imposto é: " + valorPercentualImpostoSalario);
                    break;
                case 12:
                    bool valorTestePrimo = testePrimo(7);
                    Console.WriteLine("O valor é primo? " + valorTestePrimo);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
                }
            } while (menu !=12);
        }

        public static double media(double notaUm, double notaDois, double notaTres) 
        {
            return (notaUm + notaDois + notaTres) / 3;
        }

        public static double area(double ladoUm, double ladoDois) 
        {
            return ( ladoUm * ladoDois);
        }

        public static double volume(double largura, double altura, double profundidade) 
        {
            return (largura * altura * profundidade);
        }

        public static bool valorMaiorQueDobro(int numero, int verificar) 
        {
            if (numero > verificar * 2) 
            {
                return true;
            } else 
            {
                return false;
            }
        }

        public static double[] bhaskara(int a, int b, int c) 
        {
            double delta = (b * b) - (4 * a * c);
            double x1 = 0;
            double x2 = 0;
            if (delta < 0) {
                Console.WriteLine("Delta é negativo");
            } else if (delta == 0) {
                x1 = -b / (2 * a);
                x2 = x1;
            } else {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            return new double[] { x1, x2 };
        }

        public static double mediaViagem(double distancia, double tempo) 
        {
            return (distancia/tempo);
        }

        public static double percentualImposto(double faturamento, double qtdImposto)
        {
            return (qtdImposto*100)/faturamento;
        }

        public static bool parOuImpar(int valor) 
        {
            if(valor % 2 == 0 )
                return true;
            else
            {
                return false;
            }
        }

        public static bool compareString(String stringUm, String stringDois) 
        {
            return stringUm.Equals(stringDois);
        }

        public static int convertString(double valor) 
        {
            int valorInteiro = (Int32.Parse(valor+""));
            return valorInteiro;
        }

        public static double percentualImpostoSalario(double salario) 
        {
            double percentual = -1;
            if (salario <= 1903.98) {//Até 1.903,98             | Isento
                percentual = 0;
            } else if (salario <= 1903.99 && salario >= 2826.65) { //De 1.903,99 até 2.826,65 | 7,5%
                percentual = 7.5;
            } else if (salario <= 2826.66 && salario >= 3751.05) { // De 2.826,66 até 3.751,05 | 15% 
                percentual = 15;
            } else if (salario <= 3751.06 && salario >= 5664.68) { // De 3.751,06 até 4.664,68 | 22,5%
                percentual = 22.5;
            } else if (salario > 4664.68) { // Acima de 4.664,68        | 27,5%
                percentual = 27.5;
            }
            return percentual;
        }

        public static bool testePrimo(int valor) 
        {
            for(int i = 2; i < valor; i++) {
                if(valor % i == 0) {
                    return false;
                }
            }
            return true ;
        }

    }
}
