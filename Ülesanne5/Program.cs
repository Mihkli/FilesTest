using System;
using System.IO;

namespace Ülesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random facts So Interesting You'll say, 'OMG!' ");
            string rootpath = @"C:\Users\opilane\samples\kass\funFacts.txt";
            string[] datafromfile = File.ReadAllLines(rootpath);

            Random rnd = new Random();
            int randomindex = rnd.Next(1, datafromfile.Length);

            Console.WriteLine(datafromfile[randomindex]);
        }
    }
}
