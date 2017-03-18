﻿using System;
namespace Snake
{
	public class Point
	{
		public int x;
		public int y;
		public char sym;

		public Point() { }

		public Point(int x, int y, char sym)
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public void draw()
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(sym);
		}
	}
}
