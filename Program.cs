var conta = new ContaBancaria("Davi", 100);
Console.WriteLine($"{conta.Titular} - saldo: {conta.Saldo}");

conta.Depositar(50);
Console.WriteLine($"depois do deposito: {conta.Saldo}");
