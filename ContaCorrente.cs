using System;

namespace listas{
    public class ContaCorrente 
    {
    public String numeroConta {get; set;}
    public String agencia {get; set;}
    public double saldo {get;set;}
    public String nomeTitular {get;}
    public ContaCorrente(String numeroConta, String agencia, double saldo, String nomeTitular) 
    {
        this.numeroConta = numeroConta;
        this.agencia = agencia;
        this.saldo = saldo;
        this.nomeTitular = nomeTitular; 
    }
    public void depositar(double valor) 
    {
        saldo+=valor;
    }

    public void saque(double valor) 
    {
        saldo-=valor;
        } 
    }
}