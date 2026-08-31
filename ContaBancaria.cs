public class ContaBancaria
{
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(string titular, double saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("valor de deposito tem que ser maior que zero");
            return;
        }

        Saldo += valor;
    }
}
