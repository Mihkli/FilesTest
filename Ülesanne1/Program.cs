using System;
using System.IO;

namespace Ülesanne1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\samples";

            Console.WriteLine("Enter directory name:");
            string userfolder = Console.ReadLine();

            string newdirectoryfullpath = @$"{rootpath}\{userfolder}";
            bool directoryexists = Directory.Exists(newdirectoryfullpath);

            if (directoryexists)
            {
                Console.WriteLine($"{userfolder} exists.");

            }
            else
            {
                Directory.CreateDirectory(newdirectoryfullpath);
                Console.WriteLine($"Directory {userfolder} has been created.");
            }
        }
    }
}
