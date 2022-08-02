// See https://aka.ms/new-console-template for more information

using bytbank._2.Funcionarios;
using bytbank._2.Utilitarios;
using bytbank_ADM.Funcionarios;

Console.WriteLine("Boas Vindas ao bitbank 2 ");



GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
Funcionario pedro = new Funcionario(  );
pedro.Nome = " João";
pedro.Cpf = "10001222";
pedro.Salario = 2000;

//Console.WriteLine("Nome: "  + pedro.Nome);
//Console.WriteLine("CPF :" + pedro.Cpf);
//Console.WriteLine("Salario :" + pedro.Salario);
//Console.WriteLine( "Bonificação R$ :"  + pedro.getBonificacao());
//Console.WriteLine();

Diretor paula = new Diretor();
paula.Nome = "Paula ";
paula.Cpf = "3232323232";
paula.Salario = 5000;

Console.WriteLine( "Nome: " + paula.Nome);
Console.WriteLine("CPF: " + paula.Cpf);
Console.WriteLine("Salario R$: " + paula.Salario);
Console.WriteLine("Bonificação R$ :" + paula.getBonificacao());
Console.ReadLine();

gerenciador.Registrar(pedro);
Console.WriteLine("Total  de bonificação :" + gerenciador.getBonificacao());

