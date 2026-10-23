public class ContaBancaria
{
    public string Titular { get; set; }
    public double Saldo { get; private set; }
    private List<string> historico = new List<string>();

    public ContaBancaria(string titular, double saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
        historico.Add($"abertura de conta - saldo inicial: {saldoInicial}");
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("valor de deposito tem que ser maior que zero");
            return;
        }

        Saldo += valor;
        historico.Add($"deposito de {valor}");
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("valor de saque tem que ser maior que zero");
            return;
        }

        // nao pode deixar o saldo negativo
        if (valor > Saldo)
        {
            Console.WriteLine("saldo insuficiente");
            return;
        }

        Saldo -= valor;
        historico.Add($"saque de {valor}");
    }

    public void Transferir(ContaBancaria destino, double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("valor de transferencia tem que ser maior que zero");
            return;
        }

        if (valor > Saldo)
        {
            Console.WriteLine("saldo insuficiente");
            return;
        }

        Saldo -= valor;
        destino.Saldo += valor;
        historico.Add($"transferencia de {valor} para {destino.Titular}");
        destino.historico.Add($"transferencia de {valor} recebida de {Titular}");
    }

    public void Extrato()
    {
        Console.WriteLine($"--- extrato de {Titular} ---");
        foreach (var linha in historico)
        {
            Console.WriteLine(linha);
        }
        Console.WriteLine($"saldo atual: {Saldo}");
    }
}
