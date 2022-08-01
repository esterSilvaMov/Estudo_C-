// See https://aka.ms/new-console-template for more information
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("trabalhando condicionates  ");

        //int idadeJoao = 16;
        //int quantidadeDEpessoas = 2;
        //if (idadeJoao >= 18 || quantidadeDEpessoas >1)
        //{
        //    Console.WriteLine(" seja Bem vindo ");
        //}
        //else
        //{
        //    Console.WriteLine("Desculpe você não Pode entrar ");
        //}

        int idadeJoao = 16;
        int quantidadeDEpessoas = 2;

        bool acompanhado = quantidadeDEpessoas > 1;
            bool grupo = true;

        if (idadeJoao >= 18 || acompanhado  )
        {
            Console.WriteLine(" seja Bem vindo ");
        }
        else
        {
            Console.WriteLine("Desculpe você não Pode entrar ");
        }


        Console.WriteLine("tecla enter para fechar ..");

        Console.ReadLine();
    }
}