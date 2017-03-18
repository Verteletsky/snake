using System;
namespace Snake
{
	public class Point
	{
		public int x;
		public int y;
		public char sym;

		public void draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
	}
}
