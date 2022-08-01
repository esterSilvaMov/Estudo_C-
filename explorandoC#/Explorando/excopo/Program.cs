// See https://aka.ms/new-console-template for more information
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("trabalhando excopo   ");

        int idadeJoao = 16;
        int quantidadeDEpessoas = 2;

        bool acompanhado = quantidadeDEpessoas > 1;

        string textoAdicional; 

        if(acompanhado == true)
        {
             textoAdicional = "João esta acompanhado ";
        }
        else
        {
             textoAdicional = "João não esta acompanhado "; 
        }

        if (idadeJoao >= 18)
        {
            Console.WriteLine(" seja Bem vindo ");
        }
        else
        {
            if (quantidadeDEpessoas > 0)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Desculpe você não Pode entrar ");
            }

        }

        Console.WriteLine("tecla enter para fechar ..");

        Console.ReadLine();
    }
}