using System;

namespace listas
{


public class ExercicioDois {


    public static void call() {
        Console.WriteLine("=== EXERCÍCIOS - LISTA 2 ===");

        Console.WriteLine("+-------------------------------------------------------+");
        Console.WriteLine("| 1 - Calcule a Média                                   |");
        Console.WriteLine("| 2 - Mês do Ano                                        |");
        Console.WriteLine("| 3 - Forca                                             |");
        Console.WriteLine("| 4 - Tabuada                                           |");
        Console.WriteLine("| 5 - Letra a Letra                                     |");
        Console.WriteLine("| 6 - Número ímpares multiplos de 7                     |");
        Console.WriteLine("| 7 - Calcule a Média de Notas informadas               |");
        Console.WriteLine("| 8 - Fatorial                                          |");
        Console.WriteLine("| 9 - Calculo IMC                                       |");
        Console.WriteLine("| 10 - Operadores                                       |");
        Console.WriteLine("| 11 - DESAFIO                                          |");
        Console.WriteLine("+-------------------------------------------------------+");

        int menu = 0;
        try {
            menu = Int32.Parse(Console.ReadLine());
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            menu = 0;
        }

        switch (menu) 
        {
            case 1:
                double valorCalculaMedia = calculaMedia(5, 7, 10); 
                if (valorCalculaMedia > 7)
                {
                Console.WriteLine("Você foi aprovado ");
                } else 
                Console.WriteLine("Você foi reprovado");
                break;
            case 2:
                Console.WriteLine("Digite o numero");
                int valorMes = Int32.Parse(Console.ReadLine());
                qualMes(valorMes);
                break;
            case 3:
                Console.WriteLine("Digite a palavra oculta");
                string palavra = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de tentativas");
                int tentativas = Int32.Parse(Console.ReadLine());

                for (int i = tentativas; i > 0; i--) {
                    Console.WriteLine("Digite a palavra da tentativa " + i + ": ");
                    string palavraTentativa = Console.ReadLine();

                    if (palavra.Equals(palavraTentativa)) {
                        Console.WriteLine("Acertou!!");
                        break;
                    } else {
                        Console.WriteLine("Errou!!");
                        if (i == 1) {
                            Console.WriteLine("Enforcado!");
                        }
                    }
                }
                break;
            case 4:
                 int[] valorTabuada= tabuada(5);
                break;
            case 5:
                Console.WriteLine("Digite a palavra: ");
                String palavraLetraALetra = Console.ReadLine();
                char[] letras = letraALetra(palavraLetraALetra);

                foreach (char letra in letras) {
                    Console.WriteLine($"letra");
                }
                break;
            case 6:
                Console.WriteLine("A soma dos número ímpares e múltiplos de 7 entre 1 e 500 é: " + numerosImpares());
                break;
            case 7:
                break;
            case 8:
                Console.WriteLine("Digite o número: ");
                int numero = Int32.Parse(Console.ReadLine());
                Console.WriteLine(fatorial(numero));
                break;
            case 9:
                Console.WriteLine("Digite a altura");
                double altura = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite o peso");
                double peso = Int32.Parse(Console.ReadLine());
                double imc = Imc(altura, peso);
                if (imc < 18.5) {
                    Console.WriteLine("Abaixo do Peso");
                } else if (imc >= 18.5 && imc <= 24.9) {
                    Console.WriteLine("Peso Ideal");
                } else if (imc >= 25 && imc <= 29.9) {
                    Console.WriteLine("Levemente acima do peso");
                } else if (imc >= 30 && imc <= 34.9) {
                    Console.WriteLine("Obesidade Grau I");
                } else if (imc >= 35 && imc <= 39.9) {
                    Console.WriteLine("Obesidade Grau II");
                } else if (imc >= 40) {    
                    Console.WriteLine("Obesidade Grau III (mórbida)");
                }
                break;
            case 10:
                Console.WriteLine("Digite o primeiro valor");
                int valorUm = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor");
                int valorDois = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite a operação (+ - * /)");
                char operacao = Console.ReadLine()[0];

                double resultado = operador(valorUm, valorDois, operacao);

                Console.WriteLine("O valor da operação é " + resultado);;
                break;
            case 11:
                Console.WriteLine("Digite o valor em reais: ");
                double valor = double.Parse(Console.ReadLine());
                int[] notas = notasNecessarias(valor);
                Console.WriteLine(notas.ToString());
                break;
            default:
                Console.WriteLine("Operação inválida");
                break;
        }
    }

    public static double calculaMedia(double notaUm, double notaDois, double notaTres) 
    {
        return (notaUm + notaDois + notaTres) / 3;
    }

    public static String qualMes(int mes) 
    {
        switch (mes) 
        {
            case 1:
                return "Janeiro";
            case 2:
                return "Fevereiro";
            case 3:
                return "Março";
            case 4:
                return "Abril";
            case 5:
                return "Maio";
            case 6:
                return "Junho";
            case 7:
                return "Julho";
            case 8:
                return "Agosto";
            case 9:
                return "Setembro";
            case 10:
                return "Outubro";
            case 11:
                return "Novembro";
            case 12:
                return "Dezembro";
            case 13:
            default:
                return ("Operação inválida");
        }
    }

    public static int[] tabuada(int numero) 
    {
        return new int[10];
    }

    public static char[] letraALetra(String palavra) 
    {
        char[] letras = new char[palavra.Length];

        for (int i = 0; i < letras.Length; i++) {
            letras[i] = palavra[i];
        }
        return letras;
    }

    public static int numerosImpares() 
    {
        int soma = 0;
        for (int i = 1; i < 500; i++) {
            if (i % 2 != 0 && i % 7 == 0) {
                soma = soma + i;
            }
        }
        return soma;
    }

    public static double calculaMedia(double[] notas) 
    {
        return 0;
    }

    public static int fatorial(int numero) 
    {
         int fatorial = 1;
        Console.WriteLine(numero + "! = ");
        for (int i = numero; i > 0; i--) {
            fatorial *= i;
            Console.WriteLine(i + (i != 1 ? "x" : ""));
        }
        Console.WriteLine("=");
        return fatorial;
    }

    public static double Imc(double altura, double peso) 
    {
       return peso / (altura * altura);
    }

    public static double operador(int valorUm, int valorDois, char operacao) 
    {
        double resultado = 0;
        switch (operacao) {
            case '+':
                resultado = valorUm + valorDois;
                break;
            case '-':
                resultado = valorUm - valorDois;
                break;
            case '*':
                resultado =  valorUm * valorDois;
                break;
            case '/':
                resultado = (double) valorUm / valorDois;
                break;        
            default:
                break;
        }
        return resultado;
    }

    public static int[] notasNecessarias(double valor)
    {
        double[] notas = new double[] { 200, 100, 50, 20, 10, 5, 1, 0.5 };
        int[] valorNotas = new int[notas.Length];
         for (int i = 0; i < notas.Length; i++) {
            valorNotas[i] = (int) (valor / notas[i]);
            valor -= valorNotas[i] * notas[i];
        }

        return valorNotas;
        }
    }
}
