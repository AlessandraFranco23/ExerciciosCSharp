using System;

namespace listas{
public class ExercicioCinco {
    
    public static void call() {
        Console.WriteLine("=== EXERCÍCIOS - LISTA 5 ===");

        Console.WriteLine("+-------------------------------------------------------+");
        Console.WriteLine("| 1 - Criar Pessoa                                      |");
        Console.WriteLine("| 2 - IMC de Pessoa                                     |");
        Console.WriteLine("| 3 - Conta Corrente                                    |");
        Console.WriteLine("| 4 - Movimentacao Conta                                |");
        Console.WriteLine("| 5 - Circunferencia                                    |");
        Console.WriteLine("| 6 - Cifra de César                                    |");
        Console.WriteLine("+-------------------------------------------------------+");

        int menu = 0;
        try {
            menu = Int32.Parse(Console.ReadLine());
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            menu = 0;
        }
        switch (menu) {
            // 1) Crie uma classe que represente uma Pessoa, devendo ter as propriedades Nome, Peso, Altura e Data de Nascimento e o método IMC, que retornará o valor do IMC.
            case 1:
                criarPessoa();
                break;
            /* 2) Crie um programa que receba a pessoa criada e verifique qual o IMC.

            IMC               | Classificação
            ----------------- | ------
            Abaixo de 18,5    | Abaixo do Peso
            Entre 18,6 e 24,9 | Peso Ideal
            Entre 25,0 e 29,9 | Levemente acima do peso
            Entre 30,0 e 34,9 | Obesidade Grau I
            Entre 35,0 e 39,9 | Obesidade Grau II
            Acima de 40       | Obesidade Grau III (mórbida)
            */         
            case 2:
                verificarIMC();
                break;
            // 3) Crie uma classe que represente uma Conta Corrente, devendo ter as propriedades Número da Conta, Agência, Saldo, Nome do Titular e os métodos Depósito, Saque e Saldo Total.
            case 3:
                // contaCorrente();
                break;
            // 4) Crie um programa que receba a conta corrente e deposite e saque valores, ao final imprimindo o saldo existente.
            case 4:
                // depositarValores();
                break;
            // 5) Crie uma classe que calcule a área de uma circunferência, recebendo com valor inicial o raio
            case 5:
                // circunferencia();
                break;
            // 6) Crie uma classe para Cifra de César, devendo ter um método criptografia e receba como valor inicial uma mensagem e o valor constante. Cifra de César é uma das criptografias mais antigas conhecidas, onde a chave está no valor constante, para cada letra do alfabeto atribuí-se um número (exemplo: A=1;B=2;C=3,etc), então para cada letra da mensagem, soma-se o valor correspondente a esta letra ao valor constante, gerando uma nova letra para formar a nova mensagem, ou seja, a mensagem "Ataque a roma" com um valor constante de 3 seria "dwdtxh d urpd". Dica, utilize arrays para isso.
            case 6:
                cifraCesar();
                break;
            default:
                Console.WriteLine("Operação inválida");
                break;
        }

    }

    public static void criarPessoa() {
        Pessoa pessoa = new Pessoa("Jackson", 79, 1.70, "31/03/1990");
        Console.WriteLine(
            "Nome: " + pessoa.nome + "\n"
            + "Peso: " + pessoa.peso + "\n"
            + "Altura: " + pessoa.altura + "\n"
            + "Data de Nascimento: " + pessoa.dataNascimento + "\n"
            + "IMC: " + pessoa.imc()
        );
    }

    public static void verificarIMC() {
        Pessoa pessoa = new Pessoa("Jackson", 79, 1.70, "31/03/1990");
        Console.WriteLine(
            "Nome: " + pessoa.nome + "\n"
            + "Peso: " + pessoa.peso + "\n"
            + "Altura: " + pessoa.altura + "\n"
            + "Data de Nascimento: " + pessoa.dataNascimento + "\n"
            + "IMC: " + pessoa.imc() + "\n"
            + "Calculo IMC: " + pessoa.imcTexto()
        );
    }

    public static void contaCorrente() {
        ContaCorrente contaCorrente = new ContaCorrente("123", "12345", 22.22, "Jackson");
        Console.WriteLine(
            "Numero da conta: " + contaCorrente.numeroConta + "\n"
            + "Agencia: " + contaCorrente.agencia + "\n"
            + "Saldo: " + contaCorrente.saldo + "\n"
            + "Nome do titular:" + contaCorrente.nomeTitular + "\n");
    }

    public static void depositarValores() {
        ContaCorrente contaCorrente = new ContaCorrente("123", "12345", 22.22, "Jackson");
        contaCorrente.depositar(100.00);
        contaCorrente.saque(50.00);
        Console.WriteLine(
            "Numero da conta: " + contaCorrente.numeroConta + "\n"
            + "Agencia: " + contaCorrente.agencia + "\n"
            + "Saldo: " + contaCorrente.saldo + "\n"
            + "Nome do titular:" + contaCorrente.nomeTitular + "\n");
    }

    public static void circunferencia() {
        Circunferencia circunferencia = new Circunferencia(3.3);
        Console.WriteLine(
            "Raio: " + circunferencia.raio + "\n"
            +"Circunferencia:"  + circunferencia.circunferencia());
    }

    public static void cifraCesar() {
        char[] alfabeto = new char[]{ 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
        String mensagem = "ataque a roma";
        int seed = 1;
        String mensagemCript = "";
        
        for (int contadorUm = 0; contadorUm < mensagem.Length; contadorUm++) {
            char letra = mensagem[contadorUm];
            if (letra != ' ') {
                int letraIndice = 0;
                for (int contadorDois = 0; contadorDois < alfabeto.Length; contadorDois++) {
                    if (alfabeto[contadorDois] == letra) {
                        letraIndice = contadorDois;
                        break;
                    }
                }
                mensagemCript += alfabeto[letraIndice + seed];
            } else {
                mensagemCript += " ";
            }
        }
        Console.WriteLine(mensagemCript);
    }
}

}