using System;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
            int menu = int.Parse(Console.ReadLine())
            do{

            switch (menu) {
                // 1) Crie um programa que calcule a média (`(nota1 + nota2 + nota3 / 3)`)
                case 1:
                    double valorMedia = media(5, 7, 10);
                    Console.WriteLine("A média dos números é: " + valorMedia);
                    break;
                // 2) Crie um programa que calcule a área (`lado1 * lado2`)
                case 2:
                    double area (5,3);
                    Console.WriteLine("A área " + area);
                    break;
                // 3) Crie um programa que calcule o volume (`largura * altura * profundidade`)
                case 3:
                    double volume (2,6,5);
                    Console.WriteLine("O volume é " + volume);
                    // volume(double largura, double altura, double profundidade)
                    break;
                // 4) Crie um programa que avalie se um valor é maior do que o dobro de outro valor
                case 4:
                    double valorMaiorQueDobro(double 4, double 9);
                    Console.WriteLine("O valor é maior?" + valorMaiorQueDobro)
                    break;
                // 5) Crie um programa que calcule _bhaskara_
                case 5:
                    int bhaskara(1, 4, 1);
                    Console.WriteLine("O resultado é" + bhaskara)
                    break;
                // 6) Crie um programa que calcule a velocidade média de uma viagem (`distancia (km) / tempo (h)`)
                case 6:
                    double mediaViagem(22, 2)
                    Console.WriteLine("A media da viagem é" + mediaViagem)
                    break;
                // 7) Crie um programa que calcule o percentual de imposto pago (`faturamento \ qtd imposto`)
                case 7:
                    double percentualImposto(2000, 22)
                    break;
                // 8) Crie um programa que teste se um valor é par ou ímpar
                case 8:
                    int parOuImpar(4)
                    break;
                // 9) Crie um programa que compare dois valores Strings
                case 9:
                    String compareString(a,a)
                    break;
                // 10) Crie um programa que tenha uma variável com ponto em String e converta seu valor para inteiro
                case 10:
                    String convertString(2.2);
                    break;
                // 11) Crie um programa que receba o salário e diga o valor de imposto de renda conforme abaixo:
                // Base                     | Alíquota
                // ---------                | ------
                // Até 1.903,98             | Isento
                // De 1.903,99 até 2.826,65 | 7,5%
                // De 2.826,66 até 3.751,05 | 15%
                // De 3.751,06 até 4.664,68 | 22,5%
                // Acima de 4.664,68        | 27,5%
                case 11:
                    double percentualImpostoSalario(2000);
                    break;
                // DESAFIO - Crie um programa que teste se um número é primo
                case 12:
                    int testePrimo(7)
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
                }
            } while (menu !=12)
        }

        public static double media(double notaUm, double notaDois, double notaTres) {
            return (notaUm + notaDois + notaTres) / 3;
        }

        public static double area(double ladoUm, double ladoDois) {
            return ( ladoUm * ladoDois);
        }

        public static double volume(double largura, double altura, double profundidade) {
            return (largura * altura * profundidade);
        }

        public static boolean valorMaiorQueDobro(double base, double verificar) {
            if (base > verificar * 2) {
                return true;
            } else {
                return false;
            }
        }

        public static double[] bhaskara(int a, int b, int c) {
            double delta = (b * b) - (4 * a * c);
            double x1 = 0;
            double x2 = 0;
            if (delta < 0) {
                Console.WriteLine("Delta é negativo");
            } else if (delta == 0) {
                x1 = -b / (2 * a);
                x2 = x1;
            } else {
                x1 = (-b + Math.sqrt(delta)) / (2 * a);
                x2 = (-b - Math.sqrt(delta)) / (2 * a);
            }
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            return new double[] { x1, x2 };
        }

        public static double mediaViagem(double distancia, double tempo) {
            return (distacia/tempo);
        }

        public static double percentualImposto(double faturamento, double qtdImposto) {
            /**
            * faturamento - 100
            * qtdImposto  - x
            */

            return (qtdImposto*100)/faturamento;
        }

        public static boolean parOuImpar(int valor) {
            if(valor % 2 == 0 )
                Console.WriteLine("Você informou um numero par");
            else{
                return Console.WriteLine("Você informou um numero impar");
            }
        }

        public static boolean compareString(String stringUm, String stringDois) {
            return false;
        }

        public static int convertString(String valor) {
            double valorDouble = Double.parseDouble(valor);
            int valorInteiro = (int) valorDouble;
            return valorInteiro;
        }

        public static double percentualImpostoSalario(double salario) {
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

        public static boolean testePrimo(int valor) {
            for(int i = 2; i < valor; i++) {
                if(valor % i == 0) {
                    return false;
                }
            }
            return true ;
        }

    }
}
