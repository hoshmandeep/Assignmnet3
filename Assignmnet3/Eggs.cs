namespace A3.Eggs
{
	class Egg
	{
		public enum Colors
		{
			speckled,
			brown
		}
		public double Size { get; private set; }
		public Colors Color { get; private set; }
		
		public Egg(double size, Colors color)// size, colour of the egg
		{
			Size = size;
			Color = color;
		}
		public Egg()
		{

		}
		public override string ToString()
		{
			return $"A {Size:0.0}cm {Color} egg";
		}
	}

	
	class BrokenEgg : Egg
	{
		
		public double Size { get; private set; }// for size of egg
		public Colors Color { get; private set; }// for colour of egg
		public BrokenEgg(double size, Colors color)
		{
			Size = size;
			Color = color;
		}
		public override string ToString()
		{
			return $"A {Size:0.0}cm {Color} egg that is broken";
		}

	}
}
	

