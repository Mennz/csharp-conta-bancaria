public class ContaBancaria
{
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(string titular, double saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }
}
