using System;

namespace listas{
    public class Circunferencia {
    
    public double raio {get;set;}
    public Circunferencia(double raio) {
        this.raio = raio; 

    }

    public double area() {
        return Math.PI*(Math.Pow(raio,2));;
    }

    public double circunferencia() {
        return 2*Math.PI*raio;
        }
    }

}