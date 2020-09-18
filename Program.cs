using System;

namespace Ola_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDoUsuario;
            //<---Inicio(Digite--->//
            Console.Write("Digite Seu Nome: ");
            nomeDoUsuario = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine($"Olá, {nomeDoUsuario}!");
            //<---Fim(Digite)--->//

            //<---Inicio(Sair)--->//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //<---Fim(Sair)--->//
            
        }
    }
}
