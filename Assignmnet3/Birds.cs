using System;

using A3.Eggs;
namespace A3.Birds
{
	abstract class Bird
	{
		public static Random Rand = new Random(1);
		public virtual Egg[] LayEggs(int numEggs)
		{
			Console.Error.WriteLine("Bird.LayEggs should not be called!");
			return new Egg[0];
		}
	}

	class Chicken : Bird
	{
		public override Egg[] LayEggs(int numEggs)
		{

			for (int i = 1; i < numEggs+1; ++i)
			{
				double size =Rand.NextDouble() * (4 - 2) + 2;
				Egg egg = new Egg(size, Egg.Colors.brown);
				BrokenEgg begg = new BrokenEgg(size, Egg.Colors.brown);
				Random random = new Random();
				if (random.Next(1, 100) <= 25)
				{
					Console.WriteLine(begg);
				}
				else
                {
					Console.WriteLine(egg);
				}
				
				
			}
			return new Egg[1];
		}
	}

	class Ostrich : Bird 
	{
		public override Egg[] LayEggs(int numEggs)
		{

			for (int i = 1; i < numEggs+1 ; ++i)
			{
				double size = Rand.NextDouble() * (15 - 10) + 10;
				Egg egg = new Egg(size, Egg.Colors.speckled);
				BrokenEgg begg = new BrokenEgg(size, Egg.Colors.speckled);
				Random random = new Random();
				if (random.Next(1, 100) <= 45)
				{
					Console.WriteLine(begg);
				}
				else
				{
					Console.WriteLine(egg);
				}
			}
			return new Egg[1];
		}
	}
}
