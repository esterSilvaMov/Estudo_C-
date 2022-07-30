using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas vindas Aoi ByteBank!");
/*Depois de ter definido a class (ContaCorrente) vou criar o obj   */
/*Obj*/
//ContaCorrente conta1 = new ContaCorrente(); /* obj da class atraves do obj que se usa a class */
//conta1.titular = "Andre Silva "; /*atraves do operador ponto eu entro nas propriedades da class */
//conta1.conta = "10123-x";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 100;
///* O ponto vai entrar no obj da nossa class */
///*
// Resumo
//1- Fiz uma modelagem da class 
//2- depois criei a class  com os obj que eu ia utilizar 
//3- Depois chamei os objs da class */

///*Novo */
//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Ana ";
//conta2.conta = "1111111";
//conta2.numero_agencia = 23;
//conta2.nome_agencia = "aAgência central";
//conta2.saldo = 100000;

///*Novo */
//ContaCorrene conta3 = new ContaCorrene();
//conta3.titular = "vanda ";
//conta3  .conta = "1122221";
//conta3.numero_agencia = 23;
//conta3.nome_agencia = "Agencia Central";
//conta3.saldo = 500000;


//Console.WriteLine("titular: " + conta1.titular);
//Console.WriteLine("conta: " + conta1.conta);
//Console.WriteLine("numero_agencia: " + conta1.numero_agencia);
//Console.WriteLine("nome_agencia: " + conta1.nome_agencia);  
//Console.WriteLine("numero_agencia: " + conta1.numero_agencia);
//Console.ReadKey();
//double saldo = 100;
//double saldo2 =  conta1.saldo; /*atribuindo valor a uma var */
//console.writeline(saldo == conta1.saldo);/* comparação de campo */
//console.writeline(saldo == saldo2);
//Console.WriteLine("Saldo da conta  " + conta2.titular + "Total de : " + conta2.saldo);
//conta2. Sacar( 100);
//Console.WriteLine("Saldo da " + conta2.titular + "total de: " + conta2.saldo);

//conta2.Depositar(239);
//Console.WriteLine("Deposito realizado com sucesso  Saldo atual de :  " + conta2.saldo);

//Console.WriteLine( "salda da    pré- trasferencia " + conta2.saldo);
//Console.WriteLine("saldo  do   pré - trasferencia " + conta1.saldo);
//conta2.Transferir(300, conta1);
//Console.WriteLine("saldo  do " + conta1.titular + " pré - trasferencia " + conta1.saldo);

//Console.ReadKey();

/* Primeiro formato*/
//Cliente cliente = new Cliente();

//cliente.nome = "liza Silva";
//cliente.Cpf = "10253541263";
//cliente.profissao = "Programador C#";

//ContaCorrente conta4 = new ContaCorrente();
//conta4.titular = cliente;


/* segundo formato*/
ContaCorrente conta4 = new ContaCorrente();
conta4.titular =new Cliente();
conta4.nome = "liza silva";
conta4.Cpf = "10253541263";
conta4.profissao = "programador c#";
conta4.conta = "2513252-X";
conta4.numero_agencia = 35;
conta4.nome_agencia = "Agência Central";
Console.WriteLine(Cliente.nome)
    ;
Console.ReadKey();