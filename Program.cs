using System;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
			List<string> apps = new List<string>() {};
            List<string> apps_locations = new List<string>() {};

			foreach (string file in Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "app")))
			{
				apps.Add(Path.GetFileName(file));
                apps_locations.Add(file);
			}
            Console.Clear();
            menu.make_menu(apps.ToArray(), "Your programs list!");

            // Console.WriteLine(apps_locations[menu.click_index]);
            // Console.ReadLine();

            // (menu.click_index)
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = apps_locations[menu.click_index];
            psi.UseShellExecute = true;
            psi.CreateNoWindow = true;
            Process.Start(psi);
        }
    }
}

// By Pranjal Patel