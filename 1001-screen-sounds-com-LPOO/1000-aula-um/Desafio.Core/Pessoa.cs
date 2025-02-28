class Pessoa
{
    public string nome {get;set;}

    public int idade {get; set;}
    public Conta conta;

    public Pessoa(string nome, Conta conta){
        this.nome = nome;
        this.conta = conta;
    }
}