using System;
using System.Collections.Generic;
using System.IO;

namespace Ülesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\Samples\kass\cars.txt";
            string[] datafromfile = File.ReadAllLines(filepath);
            string toyotadata = @"C:\Users\opilane\Samples\kass\toyota.txt";
            string tesladata = @"C:\Users\opilane\Samples\kass\tesla.txt";
            string bmwdata = @"C:\Users\opilane\Samples\kass\bmw.txt";

            List<string> toyotaList = new List<string>();
            List<string> BMWlist = new List<string>();
            List<string> teslalist = new List<string>();

            foreach (string element in datafromfile)
            {
                if (element.Contains("Toyota"))
                {
                    toyotaList.Add(element);
                }
                if (element.Contains("BMW"))
                {
                    BMWlist.Add(element);
                }
                if (element.Contains("Tesla"))
                {
                    teslalist.Add(element);
                }
                
            }
            
            File.WriteAllLines(toyotadata, toyotaList);
            File.WriteAllLines(tesladata, teslalist);
            File.WriteAllLines(bmwdata, BMWlist);
            
        }
    }
}
