// See https://aka.ms/new-console-template for more information
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Caucula Poupança  ");
        double investimento  = 1000;
        /*Rendimento de 0,5%  convertido ao codigo  (0.005)ao mÊs */

        investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);
        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(investimento);
            // mes = mes +1;
            //mes ++ 1;
            mes =+ 1;
        }
        Console.WriteLine("Rendimento total da sua poupança ");
       


        Console.WriteLine("tecla enter para fechar ..");

        Console.ReadLine();
    }
}
