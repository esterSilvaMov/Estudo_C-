// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("encadeando for  ");

        //*
        //**
        //***
        //****
        //*****

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas ++ )
            // que ele venha contando linha a l,inha 
        {
            for (int contadorColunas =0; contadorColunas <10; contadorColunas ++ )
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                    break;
            }
            Console.WriteLine( );
        }




        Console.WriteLine("tecla enter para fechar ..");

        Console.ReadLine();
    }
}

