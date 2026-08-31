# Conta bancaria em C#

Projeto pequeno pra praticar encapsulamento com uma classe `ContaBancaria`. Tem saldo
privado, deposito, saque com validacao pra nao deixar saldo negativo, historico das
operacoes e um menu de console pra usar tudo isso interativamente.

## O que pratiquei

- Propriedade com `private set` pra so deixar o saldo mudar por dentro da classe.
- Validacao simples nos metodos `Depositar` e `Sacar` (valor negativo, saldo
  insuficiente).
- Guardar um historico numa `List<string>` e montar um extrato a partir dele.
- Loop de menu no `Program.cs` com `switch` sobre a opcao digitada.

## Como rodar

```bash
dotnet run
```
