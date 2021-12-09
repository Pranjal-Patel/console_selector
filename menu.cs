using System;
using System.Threading;

namespace RPG
{
	public class menu
	{
		public static void make_menu(string[] menuItems, string heading)
		{
			write(heading);
			int index = 0;
			menu.draw(index, menuItems);
			while (true)
			{
				ConsoleKeyInfo keyy = Console.ReadKey();
				Console.SetCursorPosition(0,0);
                menu.draw(index, menuItems);

                if (keyy.Key == ConsoleKey.Q) break;
				if (keyy.Key == ConsoleKey.Enter)
				{
					menu.click_index = index;
					break;
				}
				
				if (keyy.Key == ConsoleKey.UpArrow)
				{
					if (index != 0) index -= 1;
					menu.draw(index, menuItems);
				}
				if (keyy.Key == ConsoleKey.DownArrow)
				{
					if (index != menuItems.Length - 1) index += 1;
					menu.draw(index, menuItems);
				}
			}
		}

		
		private static void draw(int arrow_index, string[] menuItems)
		{
			Console.SetCursorPosition(0, 1);
			string arrow = "";
			// Writing menus
			for (int i = 0; i < menuItems.Length; i++)
			{
				if (i == arrow_index)
				{
                    arrow = " -> ";
                }
				else
				{
                    Console.ResetColor();
                    arrow = "   ";
				}
				Console.Write(arrow);
				Console.WriteLine(menuItems[i] + "  ");
            }
			Console.SetCursorPosition(0, arrow_index + 1);
        }
		
		public static void write(string text)
		{
			int timeOut = text.Length;
			int width = Console.WindowWidth;
			int textAlign = (width/2) - (text.Length/2);
			
			Console.SetCursorPosition(0,0);
			for (int i = 0; i < textAlign; i++)
			{
				Console.Write(" ");
			}
			for (int i = 0; i < timeOut; i++)
			{
				Console.Write(text[i]);
				
				Thread.Sleep(30);
			}
			Console.WriteLine();
		}
		public static void Write(string text, ConsoleColor color)
		{
			int width = Console.WindowWidth;
			int textAlign = (width/2) - (text.Length/2);
			
			Console.SetCursorPosition(0,0);
			for (int i = 0; i < textAlign; i++)
			{
				Console.Write(" ");
			}
			Console.ForegroundColor = color;
			Console.WriteLine(text);
			Console.ResetColor();
		}
		
		
		public static int click_index { get; set; }
	}
}

// By Pranjal Patel