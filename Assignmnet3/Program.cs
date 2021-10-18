using System;

using A3.Birds;
using A3.Eggs;
namespace A3
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)// when it will be true
			{
				Bird bird;
				Console.Write("Press C for chicken or O for Ostrich: ");// we will se this in the starting and we will have to press C or O for further instructions
				char key = Char.ToUpper(Console.ReadKey().KeyChar);
				switch (key)
				{
					case 'C':
						bird = new Chicken();// When we will press C
						break;
					case 'O':
						bird = new Ostrich();// When we will press O
						break;
					default:
						return;
				}
				Console.Write("\nHow many eggs should it lay? ");// we will type any numerical value
				if (!int.TryParse(Console.ReadLine(), out int numEggs)) { return; }
				Egg[] eggs = bird.LayEggs(numEggs);
				DisplayEggs(eggs);
			}
		}

		static void DisplayEggs(Egg[] eggs)
		{
			foreach (var egg in eggs)
			{
				Console.WriteLine(egg);
			}
		}
	}
}
