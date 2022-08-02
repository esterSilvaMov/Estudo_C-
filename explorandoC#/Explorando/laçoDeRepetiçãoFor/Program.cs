// See https://aka.ms/new-console-template for more information
class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laço de Repetição for  ");

        double investimento = 1000;

        for (int mes = 1; mes <=12; mes = mes + 1 )
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês" + mes + "você tem R$: " + investimento );
        }
   
       



        Console.WriteLine("tecla enter para fechar ..");

        Console.ReadLine();
    }
}

