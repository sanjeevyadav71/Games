using CardGame;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Card Game");
			ConsoleUIGamePlay();
		}

		private static void ConsoleUIGamePlay()
		{
			ICardPlay gameplay = new CardPlay();
			bool exit = false;

			while (!exit)
			{
				Console.WriteLine("\nPress - ");
				Console.WriteLine("1. Play a Card");
				Console.WriteLine("2. Shuffle the Deck");
				Console.WriteLine("3. Restart the Game");
				Console.WriteLine("4. Exit the Game");

				var input = Console.ReadLine();
				switch (input)
				{
					case "1":
						if (gameplay.PlayCard(out string card))
							Console.WriteLine(card);
						else
							Console.WriteLine("All Cards Played. Choose another option");

						break;
					case "2":
						gameplay.Shuffle();
						break;

					case "3":
						gameplay.Restart();
						break;

					case "4":
						exit = true;
						break;

					default:
						Console.WriteLine("Please enter valid option, integer values from 1 to 4");
						break;
				}
			}
		}
	}
}
