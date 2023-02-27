using System;
using System.IO;
using System.Linq;
using System.Numerics;

namespace listas 

{
    public class ExercicioTres {
    public static void call() {
        Console.WriteLine("=== EXERCÍCIOS - LISTA 3 ===");

        Console.WriteLine("+-------------------------------------------------------+");
        Console.WriteLine("| 1 - Tabuada com Arquivo                               |");
        Console.WriteLine("| 2 - Ler e imprimir arquivo de texto                   |");
        Console.WriteLine("| 3 - Operações básicas com a Main                      |");
        Console.WriteLine("| 4 - Exponenciação com Precisão Arbitrária             |");
        Console.WriteLine("| 5 - Nome aleatório de 5 pessoas                       |");
        Console.WriteLine("| 6 - Calcular Raio e Área                              |");
        Console.WriteLine("| 7 - Avaliar se TXT tem JAVA                           |");
        Console.WriteLine("| 8 - 10 primeiros dígitos                              |");
        Console.WriteLine("| 9 - Área com a Main                                   |");
        Console.WriteLine("| 10 - Receba nome de arquivo na Main com valores       |");
        Console.WriteLine("| 11 - Ler e imprimir arquivo de texto                  |");
        Console.WriteLine("+-------------------------------------------------------+");

        int menu = 0;
        try {
            menu = Int32.Parse(Console.ReadLine());
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            menu = 0;
        }

        switch (menu) {
            // 1) Crie um programa que receba um valor e calcule a tabuada deste valor, salvando seu resultado em um arquivo de texto.
            case 1:
                Console.WriteLine("Digite o numero");
                int valorTabuada = Int32.Parse(Console.ReadLine());
                tabuada(valorTabuada);
                break;
            // 2) Crie um programa que leia e imprima no console todas as linhas de um arquivo de texto.
            case 2:
                Console.WriteLine("Digite o endereo do arquivo");
                string enderecoArquivo = Console.ReadLine();
                lerArquivoTexto(enderecoArquivo);
                break;
            // 3) Crie um programa que receba como entrada da classe Main dois valores numéricos e calcule as operações básicas com eles.
            case 3:
                // operacoesBasicas(int numeroUm, int numeroDois)
                break;
            // 4) Crie um programa que execute uma operação de Exponenciação com o valor inteiro com precisão arbitrária.
            case 4:
                Console.WriteLine("Digite um numero");
                int valorBase = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite um numero da exponencial");
                int valorExpo = Int32.Parse(Console.ReadLine());
                Console.WriteLine(bigIntExpo(valorBase, valorExpo));
                break;
            // 5) Crie um programa que receba o nome de 5 pessoas e aleatorize eles.
            case 5:
                string[] nome = new string [5];
                for(int x = 0; x <= 5; x++)
                {
                    nome [x] = Console.ReadLine();
                }
                aleatorizarPessoas(nome);
                break;
            // 6) Crie um programa que calcule o raio e a área de uma circunferência (`C = 2πr` e `A = π(r²)`).
            case 6:
                Console.WriteLine("Digite um raio");
                double valorRaio = double.Parse(Console.ReadLine());
                double[] areaCircunferencia = areaECircunferencia(valorRaio);
                Console.WriteLine("area " + areaCircunferencia[0]);
                Console.WriteLine("circunferencia" + areaCircunferencia[1]);
                break;
            // 7) Crie um programa que avalie se um arquivo de texto possui a string "JAVA".
            case 7:
                Console.WriteLine("Digite o endereo do arquivo");
                string enderecoArquivoJava = Console.ReadLine();
                hasJava(enderecoArquivoJava);
                break;
            // 8) Crie um programa que leia as linhas de um arquivo e imprima no console apenas os 10 primeiros digitos de cada linha.
            case 8:
                Console.WriteLine("Digite o endereo do arquivo");
                string enderecoArquivoDigitos = Console.ReadLine();
                dezDigitos(enderecoArquivoDigitos);
                break;
            // 9) Crie um programa que receba como entrada da classe Main dois valores numéricos e calcule a área dos valores (`area = lado1 * lado2`).
            case 9:
                // calculaArea(double numeroUm, double numeroDois);
                break;
            // 10) Crie um programa que receba como entrada da classe Main o nome de um arquivo de texto que contenha valores numéricos e some todos os valores, imprimindo no console a soma.
            case 10:
                // somaValoresArquivo(String arquivo);
                break;
            // ## DESAFIO - Crie um Jogo da Forca com Arquivos de Texto**
            case 11:
                Console.WriteLine("Digite a palavra oculta");
                string palavra = Console.ReadLine();
                break;
            default:
                Console.WriteLine("Operação inválida");
                break;
        }
        
    }

    public static int tabuada(int numero) {
        int resp = 0;
        StreamWriter sw = new StreamWriter("C:\\Test.txt");
        for (int x = 1; x <= 10; x++)
			{
				resp =  numero * x;
                sw.WriteLine(numero + "*" + x + "=" + resp);
			}
            sw.Close();
            return resp;
    }

    public static void lerArquivoTexto(String arquivo) {
        StreamReader sr = new StreamReader(arquivo);
        string line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        }

    public static int[] operacoesBasicas(int numeroUm, int numeroDois) {
        return new int[4];
    }

    public static double bigIntExpo(int valor, int pow) {

        return Math.Pow(valor, pow);
    }

     public static void aleatorizarPessoas(string[] pessoas) {
        Random rnd = new Random();
        string [] nomesAleatorios = pessoas.OrderBy(x=>rnd.Next()).ToArray();
        for(int x = 0; x <= 5; x++)
                {
                    Console.WriteLine(nomesAleatorios[x]);
                }
     }

    public static double[] areaECircunferencia(double raio) {
        double area = Math.PI*(Math.Pow(raio,2));
        double circunferência = 2*Math.PI*raio;
        return new double[2]{area,circunferência};
    }

    public static void  hasJava(String arquivo) {
        StreamReader sr = new StreamReader(arquivo);
        string line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            if(line.Contains("Java"))
            {
                Console.WriteLine ("Encontrado");
            }
            line = sr.ReadLine();
        }
        sr.Close();
        }

    public static void dezDigitos(String arquivo) {
        StreamReader sr = new StreamReader(arquivo);
        string line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line.Substring(0,10));
            line = sr.ReadLine();
        }
        sr.Close();
        
    }

    public static double calculaArea(double numeroUm, double numeroDois) {
        return 0;
    }

    public static double somaValoresArquivo(String arquivo) {
        return 0;
    }

    public static void forcaComTxt() {
        StreamReader sr = new StreamReader("C:\\Forca.txt");
        StreamWriter sw = new StreamWriter("C:\\Test.txt");
        string palavraOculta = sr.ReadLine();
        sr.Close();
        Console.WriteLine("Digite a quantidade de tentativas");
                int tentativas = Int32.Parse(Console.ReadLine());

                for (int i = tentativas; i > 0; i--) {
                    sw.WriteLine("Digite a palavra da tentativa " + i + ": ");
                    string palavraTentativa = Console.ReadLine();

                    if (palavraOculta.Equals(palavraTentativa)) {
                        sw.WriteLine("Acertou!!");
                        break;
                    } else {
                        sw.WriteLine("Errou!!");
                        if (i == 1) {
                            sw.WriteLine("Enforcado!");
                        }
                    }
                }
        
    }
}
}

