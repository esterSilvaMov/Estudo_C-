// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laço de Repetição for  ");

        double fatorRendimento = 1.005;
        double investimento = 1000; 

        for(int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;

            Console.WriteLine("depois de 5 anos voce tera  " + investimento );
        }

       



        Console.WriteLine("tecla enter para fechar ..");

        Console.ReadLine();
    }
}

