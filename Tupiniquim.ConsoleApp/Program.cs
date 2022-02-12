using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comando, posicaoInicial;
            int posY = 0;
            int posX = 0;
            char direcao = 'N';

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Robô Tupiniquim em missão à Marte!\n");
            Console.ResetColor();

            for (int j = 0; j < 2; j++)
            {
                Console.Write("\nDigite o X onde está o Robô: ");
                posX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Agora, o Y onde está o Robô: ");
                posY = Convert.ToInt32(Console.ReadLine());
                Console.Write("Em seguida, digite a rotação inicial: ");
                direcao = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Digite os comandos de movimento: ");
                comando = Console.ReadLine();

                char[] instrucoes = comando.ToCharArray();

                for (int i = 0; i < instrucoes.Length; i++)
                {
                    if (instrucoes[i] == 'M')
                    {
                        if (direcao == 'N')
                        {
                            posY = posY + 1;
                        }
                        if (direcao == 'S')
                        {
                            posY = posY - 1;
                        }
                        if (direcao == 'L')
                        {
                            posX = posX + 1;
                        }
                        if (direcao == 'O')
                        {
                            posX = posX - 1;
                        }
                    }
                    if (instrucoes[i] == 'D')
                    {
                        if (direcao == 'N')
                        {
                            direcao = 'L';
                        }
                        else if (direcao == 'L')
                        {
                            direcao = 'S';
                        }
                        else if (direcao == 'S')
                        {
                            direcao = 'O';
                        }
                        else if (direcao == 'O')
                        {
                            direcao = 'N';
                        }
                    }
                    if (instrucoes[i] == 'E')
                    {
                        if (direcao == 'N')
                        {
                            direcao = 'O';
                        }
                        else if (direcao == 'O')
                        {
                            direcao = 'S';
                        }
                        else if (direcao == 'S')
                        {
                            direcao = 'L';
                        }
                        else if (direcao == 'L')
                        {
                            direcao = 'N';
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sua posição final é: " + posX + " " + posY + " " + direcao + ".");
                Console.ResetColor();
            }
            Console.ReadLine();
        }
    }
}
