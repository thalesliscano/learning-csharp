class Conta
{
    public int numeroIndicador {get;set;}
    private string titular {get; set;}
    private double saldo;
    private string senha;
    private string palavraDeConfirmacao;

    public Conta(int numeroIndicador, string titular, double saldo, string senha, string palavraDeConfirmacao)
    {
        this.numeroIndicador = numeroIndicador;
        this.titular = titular;
        this.saldo = saldo;
        this.senha = senha;
        this.palavraDeConfirmacao = palavraDeConfirmacao;
    }
    public string GetSaldo(string senhaDigitada)
    {
        Console.WriteLine("\nACESSANDO CONTA...");
        return senhaDigitada == senha ? $"{saldo}" : "Senha incorreta!";
    }

    public string GetSenha(string palavraDigitada)
    {
        Console.WriteLine("\nANALISANDO PALAVRA CHAVE PARA MANDAR SUA SENHA...");
        return palavraDigitada == palavraDeConfirmacao ? senha: "Palavra errada!";
    }

    public void SetSenha(string novaSenha)
    {
        System.Console.WriteLine("\nMODIFICANDO SENHA!");
        string senhaDigitada = Console.ReadLine();
        if(senhaDigitada != senha)
            Console.WriteLine("Senha incorreta, não deu para modificar sua senha!");
        else
            if(novaSenha != senha)
                this.senha = novaSenha;
    }
}