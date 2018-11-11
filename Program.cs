using System;

namespace eskayrim
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            while (true)
            {
                Console.Write("Esmetân chist?");
                player.name = Console.ReadLine().ToString();
                Console.Write($"Esmetân {player.name} ast?");
                Console.Read();
            }
        }
    }
}
