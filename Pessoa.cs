using System;

namespace listas{
public class Pessoa {
    public String nome {get; set;}
    public double peso {get; set;}
    public double altura {get; set;}
    public String dataNascimento{get;set;}
    public Pessoa(String nome, double peso, double altura, String dataNascimento) {
        this.nome = nome;
        this.peso = peso;
        this.altura = altura;
        this.dataNascimento = dataNascimento; 
        
    }
    public double imc() {
        return peso / (altura * altura);
    }

    public String imcTexto() {
        double valor = imc();
                if (valor < 18.5) {
                    return ("Abaixo do Peso");
                } else if (valor >= 18.5 && valor <= 24.9) {
                    return ("Peso Ideal");
                } else if (valor >= 25 && valor <= 29.9) {
                    return ("Levemente acima do peso");
                } else if (valor >= 30 && valor <= 34.9) {
                    return ("Obesidade Grau I");
                } else if (valor >= 35 && valor <= 39.9) {
                    return ("Obesidade Grau II");
                } else if (valor >= 40) {    
                    return ("Obesidade Grau III (mórbida)");
                }
                return "";
        }
    }
}