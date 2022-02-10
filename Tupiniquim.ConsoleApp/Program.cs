using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string posicaoInicial;

            posicaoInicial = "0,0,N";

            Console.WriteLine("Robô Tupiniquim em missão à Marte!");
            Console.Write("\nSeu posicionamento é: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(posicaoInicial);
            Console.ResetColor();
            Console.Write("Como deseja se mover? Digite: ");

            Console.ReadLine();
        }
    }
}
