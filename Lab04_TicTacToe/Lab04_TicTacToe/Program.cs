using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetPlayers();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        }

        static void GetPlayers()
        {
            Console.WriteLine("Please enter a name for player one.");
            Player p1 = new Player();
            p1.Name = Console.ReadLine();
            p1.Marker = "X";
            Console.WriteLine($"Hello {p1.Name}, it's now your opponents turn to enter their name.");

            Console.WriteLine("Please enter a name for player two");
            Player p2 = new Player();
            p2.Name = Console.ReadLine();
            p2.Marker = "O";

            Console.WriteLine($"For this game, {p1.Name} will be {p1.Marker}, and {p2.Name} will be {p2.Marker}");

            Game newGame = new Game(p1, p2);
        }


    }
}
