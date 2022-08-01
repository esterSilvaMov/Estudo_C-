// See https://aka.ms/new-console-template for more information
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 Variavel. flutuante ");
        double salario; /* este tipo de variavel permite armasenar numeros com virgulas */
        salario = 3000.13;
        double idade;
        idade = 7.5 / 3; /* para não perde a propriedade de  do numero inteiro  sempre ponha o , 0  caso não seja quebrado */
        Console.WriteLine( idade    );
        Console.WriteLine(salario);
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}