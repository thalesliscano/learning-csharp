Conta conta = new Conta(12345, "Thales", 234.23, "123456", "limao");
Pessoa pessoa = new Pessoa("Thales", conta);

Console.WriteLine($"Pessoa -- Nome {pessoa.nome} | {pessoa.conta.GetSaldo("123456")} ");
pessoa.conta.SetSenha("12345");
Console.WriteLine($"Pessoa -- Nome {pessoa.nome} | Conta {pessoa.conta.GetSaldo("123456")} ");
Console.WriteLine($"Pessoa -- Nome {pessoa.nome} | Conta {pessoa.conta.GetSaldo("12345")} ");
Console.WriteLine($"Pessoa -- Nome {pessoa.nome} | {pessoa.conta.GetSenha("limao")} ");

