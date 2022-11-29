using bytebank;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Davi Kennedy";
conta1.conta = "10123-X";
conta1.numeroAgencia = 23;
conta1.nomeAgencia = "Agência Central";
conta1.saldo = 237.50;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Silva";
conta2.conta = "111999-X";
conta2.numeroAgencia = 23;
conta2.nomeAgencia = "Agência Central";
conta2.saldo = 250.0;

Console.WriteLine($"Saldo de {conta2.titular}: R$ {conta2.saldo}");
conta2.Sacar(-50);
Console.WriteLine($"Saldo de {conta2.titular}: R$ {conta2.saldo}");

/*Console.WriteLine($"Titular: {conta1.titular}");
Console.WriteLine($"Conta: {conta1.conta}");
Console.WriteLine($"Número da agência: {conta1.numeroAgencia}");
Console.WriteLine($"Nome da agência: {conta1.nomeAgencia}");
Console.WriteLine($"Saldo: {conta1.saldo}");*/

Console.ReadKey();