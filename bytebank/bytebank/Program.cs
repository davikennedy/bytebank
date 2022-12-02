using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!");

/*
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Davi Kennedy";
conta1.conta = "10123-X";
conta1.numeroAgencia = 23;
conta1.nomeAgencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Silva";
conta2.conta = "111999-X";
conta2.numeroAgencia = 23;
conta2.nomeAgencia = "Agência Central";
conta2.saldo = 100;

Console.WriteLine("");
Console.WriteLine($"Saldo de {conta1.titular}: R$ {conta1.saldo}");
Console.WriteLine($"Saldo de {conta2.titular}: R$ {conta2.saldo}");

Console.WriteLine("");
bool transferencia = conta1.Transferir(50, conta2);
Console.WriteLine($"Transferência realizada com sucesso? {transferencia}");
Console.WriteLine($"Saldo de {conta1.titular}: R$ {conta1.saldo}");
Console.WriteLine($"Saldo de {conta2.titular}: R$ {conta2.saldo}");

Console.WriteLine($"Titular: {conta1.titular}");
Console.WriteLine($"Conta: {conta1.conta}");
Console.WriteLine($"Número da agência: {conta1.numeroAgencia}");
Console.WriteLine($"Nome da agência: {conta1.nomeAgencia}");
Console.WriteLine($"Saldo: {conta1.saldo}");

Cliente cliente1 = new Cliente();
cliente1.nome = "Davi Kennedy";
cliente1.cpf = "012.345.678-90";
cliente1.profissao = "Desenvolvedor C#";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = new Cliente();
conta3.titular.nome = "Davi Kennedy";
conta3.titular.cpf = "012.345.678-90";
conta3.titular.profissao = "Desenvolvedor C#";
conta3.conta = "251312-X";
conta3.numeroAgencia = 23;
conta3.nomeAgencia = "Agência Central";
conta3.saldo = 100;

Console.WriteLine($"{cliente1.nome}");
Console.WriteLine($"{conta3.titular.nome}");

Cliente sarah = new Cliente();
sarah.Nome = "Sarah Silva";

ContaCorrente conta4 = new ContaCorrente(23, "25135-X");
conta4.Saldo = 100;
conta4.Titular = sarah;
Console.WriteLine($"Titular: {conta4.Titular.Nome}");
Console.WriteLine($"Saldo: R$ {conta4.Saldo}");
Console.WriteLine($"Número da Agência: {conta4.NumeroAgencia}");
Console.WriteLine($"Número da Agência: {conta4.Conta}"); 

ContaCorrente conta5 = new ContaCorrente(23, "25135-X");
ContaCorrente conta6 = new ContaCorrente(25, "13275-X");

Console.WriteLine(ContaCorrente.TotalContasCriadas);*/

Cliente sarah = new Cliente();
sarah.Nome = "Sarah Silva";
sarah.Profissao = "Professora";
sarah.Cpf = "11111111-12";

Cliente ester = new Cliente();
ester.Nome = "Ester Almeida";
ester.Profissao = "Advogada";
ester.Cpf = "868524125-32";

Console.WriteLine("Total de clientes: " + Cliente.TotalClientes);

ContaCorrente contaAndre = new ContaCorrente(159, "152869-x");
contaAndre.Titular = new Cliente();
contaAndre.Titular.Nome = " André Pereira";
contaAndre.Titular.Profissao = "Auxiliar Administrativo";
contaAndre.Saldo = 100;

Console.WriteLine("Total de clientes: " + Cliente.TotalClientes);

Console.ReadKey();