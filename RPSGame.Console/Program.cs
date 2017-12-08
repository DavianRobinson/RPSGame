using System;
using RPSGame.Domain;

namespace RPSGame.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new ConsoleGameEngine(Console.In, Console.Out, Console.Error);
            g.Init();
        }
    }
}
