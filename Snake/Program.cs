﻿using System;

namespace Snake
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Point p1 = new Point(1,3,'*');
			p1.draw();

			Point p2 = new Point(4, 5, '#');
			p2.draw();

			Console.ReadLine();
		}
	}
}
