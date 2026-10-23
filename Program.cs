Console.Write("nome do titular: ");
var nome = Console.ReadLine();
if (string.IsNullOrWhiteSpace(nome))
{
    nome = "sem nome";
}

var conta = new ContaBancaria(nome, 0);

Console.Write("nome do titular da outra conta: ");
var nomeOutra = Console.ReadLine();
if (string.IsNullOrWhiteSpace(nomeOutra))
{
    nomeOutra = "sem nome";
}

var contaOutra = new ContaBancaria(nomeOutra, 0);

var continuar = true;
while (continuar)
{
    Console.WriteLine();
    Console.WriteLine("1 - depositar");
    Console.WriteLine("2 - sacar");
    Console.WriteLine("3 - extrato");
    Console.WriteLine("4 - transferir para a outra conta");
    Console.WriteLine("5 - extrato da outra conta");
    Console.WriteLine("0 - sair");
    Console.Write("opcao: ");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("valor do deposito: ");
            var valorDeposito = double.Parse(Console.ReadLine() ?? "0");
            conta.Depositar(valorDeposito);
            break;

        case "2":
            Console.Write("valor do saque: ");
            var valorSaque = double.Parse(Console.ReadLine() ?? "0");
            conta.Sacar(valorSaque);
            break;

        case "3":
            conta.Extrato();
            break;

        case "4":
            Console.Write("valor da transferencia: ");
            var valorTransferencia = double.Parse(Console.ReadLine() ?? "0");
            conta.Transferir(contaOutra, valorTransferencia);
            break;

        case "5":
            contaOutra.Extrato();
            break;

        case "0":
            continuar = false;
            break;

        default:
            Console.WriteLine("opcao invalida");
            break;
    }
}
