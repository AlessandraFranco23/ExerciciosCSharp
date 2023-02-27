using System;
using System.Collections.Generic;

namespace listas 
{
    public class ExercicioQuatro {
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
            // 1) Crie um programa que questione a quantidade de notas a ser informada, receba as notas e calcule a média.
            case 1:
                Console.WriteLine("Digite quantas notas:");
                int numNotas = Int32.Parse(Console.ReadLine());
                double []notas=new double[numNotas];
                for(int x = 0; x <= numNotas; x++){
                    Console.WriteLine("Digite as nota:");
                    notas[x] = double.Parse(Console.ReadLine());
                }
                calculaMedia(notas);
                break;
            // 2) Crie um programa que imprima um arrays com Foreach.
            case 2:
                 printArray(new String[]{ "Teste", "imprimir", "foreach" });
                break;
            // 3) Crie um programa que leia 10 valores double e salve em um array, depois imprima esses valores.
            case 3:
                Console.WriteLine("Digite 10 numeros");
                int num = Int32.Parse(Console.ReadLine());
                double []numeros=new double[num];
                for(int x = 0; x <= 10; x++){
                    Console.WriteLine(num);
                    numeros[x] = double.Parse(Console.ReadLine());
                }
                dezValores(numeros);
                break;
            // 4) Crie um programa que leia 10 valores int e salve em um array, depois imprima se esses valores são pares ou ímpares.
            case 4:
                Console.WriteLine("Digite 10 numeros");
                int numero = Int32.Parse(Console.ReadLine());
                int []number=new int[numero];
                for(int x = 0; x <= 10; x++){
                    Console.WriteLine(number);
                    number[x] = Int32.Parse(Console.ReadLine());
                }
                dezValoresInt(number);
                break;
            // 5) Crie um programa que possua uma collection que represente as 52 cartas do baralho, imrpima elas.
            case 5:
                baralho();
                break;
            // 6) Crie um programa que una duas listas de inteiros.
            case 6:
                mergeIntList(new List<int> () {1,2,3,4,5}, new List<int> () {6,7,8,9,10});
                break;
            // 7) Crie um programa que simule a fila de atendimento de um banco.
            case 7:
                filaBanco();
                break;
            // 8) Crie um programa que receba a temperatura média de cada mês do ano e após exiba a temperatura média do ano.
            case 8:
                // double temperaturaMedia(double[] temperaturas);
                 String[] meses = new String[] {
                    "Jan",
                    "Fev",
                    "Mar",
                    "Abr",
                    "Mai",
                    "Jun",
                    "Jul",
                    "Ago",
                    "Set",
                    "Out",
                    "Nov",
                    "Dez"
                };
                double[] temperaturas = new double[12];
                for (int i = 0; i < meses.Length; i++) {
                    Console.WriteLine("Digite a temperatura de " + meses[i]);
                    temperaturas[i] = double.Parse(Console.ReadLine()); ;
                }
                Console.WriteLine("A temperatura média do ano é: " + temperaturaMedia(temperaturas));
                break;
            // 9) Crie dois arrays de 10 posições e depois gere um terceiro array com os valores intercalados desses dois arrays, ao final, imprima os 3.
            case 9:
                 int[] listaUm = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] listaDois = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] mergeListAlt = alternarArray(listaUm, listaDois);
                Console.WriteLine((listaUm.ToString()));
                Console.WriteLine((listaDois.ToString()));
                Console.WriteLine((mergeListAlt.ToString()));
                break;
            // 10) Crie um programa que leia 20 valores, calcule a média aritmética desses valores e imprima os valores que são inferiores a esta média.
            case 10:
                int[] valoresVinte = new int[20];
                for (int i = 0; i < valoresVinte.Length; i++) {
                    Console.WriteLine("Digite o valor " + (i + 1));
                    valoresVinte[i] += Int32.Parse(Console.ReadLine());
                }
                mediaVinte(valoresVinte);
                break;
            // DESAFIO
            case 11:
                // detetive();
                break;
        
            default:
                Console.WriteLine("Operação inválida");
                break;
        }
    }   

    // 1) Crie um programa que questione a quantidade de notas a ser informada, receba as notas e calcule a média.
    public static double calculaMedia(double[] notas) {
        double somaNota = 0;
        for(int x = 0; x <= notas.Length; x++){
            somaNota+=notas[x];
        }
        return (somaNota/notas.Length);
    }
    // 2) Crie um programa que imprima um arrays com Foreach.
    public static void printArray(String[] array) {
        foreach (string item in array)
        {
            Console.WriteLine(item);
        }
        
    }
    // 3) Crie um programa que leia 10 valores double e salve em um array, depois imprima esses valores.
    public static void dezValores(double[] valores) {
        for(int x = 0; x <= 10; x++){
            Console.WriteLine(valores[x]);
        }
        
    }
    // 4) Crie um programa que leia 10 valores int e salve em um array, depois imprima se esses valores são pares ou ímpares.
    public static void dezValoresInt(int[] valores) {
        for(int x = 0; x <= 10; x++){
            if(valores [x] % 2 ==0){
                Console.WriteLine("É um numero par");
            }else 
            {
                Console.WriteLine("É um numero impar");
            }
            Console.WriteLine(valores[x]);
        }
        
        
    }
    // 5) Crie um programa que possua uma collection que represente as 52 cartas do baralho, imprima elas.
    public static  void baralho() {
        String[] nipes = new String[] { "Paus", "Copas", "Espadas", "Ouros" };
        String[] numeros = new String[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        foreach (String numero in numeros) {
            foreach (String nipe in nipes) {
                Console.WriteLine(numero + " " + nipe);
            }
        }
    }
    // 6) Crie um programa que una duas listas de inteiros.
    public static List<int> mergeIntList(List<int> listaUm, List<int> listaDois) {
        listaUm.AddRange(listaDois);
        return listaUm;
    }
    // 7) Crie um programa que simule a fila de atendimento de um banco.
    public static void filaBanco() {
        LinkedList<String> filaPadrao = new LinkedList<String>();
        LinkedList<String> filaPreferencial = new LinkedList<String>();

        Console.WriteLine("Bem vindo ao banco");
        int opc = 0;
        do {
            Console.WriteLine("Digite a operação desejada");
            Console.WriteLine("1 - Atendimento Normal");
            Console.WriteLine("2 - Atendimento Preferencial");
            Console.WriteLine("3 - Chamar número");
            Console.WriteLine("0 - Sair");
            opc = Int32.Parse(Console.ReadLine());
            switch (opc) {
                case 0:
                    Console.WriteLine("Adeus");
                    break;
                case 1:
                    Console.WriteLine("Digite o nome da pessoa: ");
                    filaPadrao.AddFirst(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Digite o nome da pessoa: ");
                    filaPreferencial.AddFirst(Console.ReadLine());
                    break;
                case 3:
                    String nome = filaPreferencial.First.Value;
                    if (nome != null) {
                        Console.WriteLine("Chamar: " + nome);
                    } else {
                        nome = filaPadrao.First.Value;
                        if (nome != null) {
                            Console.WriteLine("Chamar: " + nome);
                        } else {
                            Console.WriteLine("Não há ninguém na fila");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
        } while (opc != 0);


    }
    // 8) Crie um programa que receba a temperatura média de cada mês do ano e após exiba a temperatura média do ano.
    public static double temperaturaMedia(double[] temperaturas) {
        double soma = 0;
        foreach (double temperatura in temperaturas) {
            soma += temperatura;
        }
        return soma / temperaturas.Length;
    }
    // 9) Crie dois arrays de 10 posições e depois gere um terceiro array com os valores intercalados desses dois arrays, ao final, imprima os 3.
    public static int[] alternarArray(int[] listaUm, int[] listaDois) {
        int[] intercalado = new int[listaUm.Length + listaDois.Length];
        int cnt = 0;
        for (int i = 0; i < listaUm.Length; i++) {
            intercalado[cnt] = listaUm[i];
            cnt++;
            intercalado[cnt] = listaDois[i];
            cnt++;
        }
        return intercalado;
    }
    // 10) Crie um programa que leia 20 valores, calcule a média aritmética desses valores e imprima os valores que são inferiores a esta média.
    public static void mediaVinte(int[] valores) {
        int soma = 0;
        foreach (int i in valores) {
            soma += i;
        }
        double media = soma / valores.Length;

        foreach (int i in valores) {
            if (media <= i) {
                Console.WriteLine("O valor " + i + " é menor que a média.");
            }    
        }
    }

    public static void detetive() {
        
    }
}
}
