using System;
using System.IO;

namespace Ülesanne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\samples\kass";
            string toyota = "toyota";
            string bmw = "bmw";
            string tesla = "tesla";

            string toyotapath = $@"{rootpath}\{toyota}.txt";
            string bmwpath = $@"{rootpath}\{bmw}.txt";
            string teslapath = $@"{rootpath}\{tesla}.txt";

            bool toyotaexists = File.Exists(toyotapath);
            bool bmwexists = File.Exists(bmwpath);
            bool teslaexists = File.Exists(teslapath);

            if(toyotaexists && bmwexists && teslaexists)
            {
                Console.WriteLine("Files already exist");
            }
            else
            {
                File.Create(toyotapath);
                File.Create(bmwpath);
                File.Create(teslapath);
                Console.WriteLine("Files have been created");
            }

        }
    }
}
