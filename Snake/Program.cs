using System;
using System.Collections.Generic;

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

			List<int> list = new List<int>();
			list.Add(0);
			list.Add(1);
			list.Add(2);

			foreach (int x in list) 
			{
				Console.WriteLine(x);	
			}

			List<Point> pList = new List<Point>();
			pList.Add(p1);
			pList.Add(p2);

			List<char> listChar = new List<char>();
			listChar.Add('*');
			listChar.Add('#');

			foreach (char s in listChar)
			{
				Console.WriteLine(s);
			}

			Console.ReadLine();
		}
	}
}
