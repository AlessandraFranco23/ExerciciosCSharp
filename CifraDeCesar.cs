using System;

namespace listas{
    public class CifraDeCesar {

    public String mensagem {get;set;}
    public int seed {get;set;}
    public CifraDeCesar(String mensagem, int seed) {
        this.mensagem = mensagem;
        this.seed = seed; 
    }

    public String mensagemCifrada() {
        return "";
        }
    
    }
}