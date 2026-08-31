var conta = new ContaBancaria("Davi", 100);
Console.WriteLine($"{conta.Titular} - saldo: {conta.Saldo}");

conta.Depositar(50);
Console.WriteLine($"depois do deposito: {conta.Saldo}");

conta.Sacar(30);
Console.WriteLine($"depois do saque: {conta.Saldo}");

conta.Sacar(1000);

conta.Extrato();
