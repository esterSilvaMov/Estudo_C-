// See https://aka.ms/new-console-template for more information
class Programa
{
    static void Main(string[] args)
    {
        
        
            char letra = 'a'; /* char  é uma variavel usada para letra */
            Console.WriteLine(letra);

            letra = (char)65;
            Console.WriteLine(letra);

            letra = (char)(65 +1) ;
            Console.WriteLine(letra);

            letra = (char)(65 - 1);
            Console.WriteLine(letra);

        string primeiraFRase = " Alura  arara  quara ";
        Console.WriteLine(primeiraFRase  + 22 );

        string vazia = " ";
        Console.WriteLine(vazia);

        string cursos = " Cursos disponiveis : Go ";
        Console.WriteLine(cursos);




            Console.WriteLine("tecla enter para fechar ..");

            Console.ReadLine();
        


    }
}