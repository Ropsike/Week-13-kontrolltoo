using System;
using System.IO;
using System.Collections.Generic;

namespace Ülesanne_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = @"C:\Users\opilane\Samples\";

            string[] datafromfile = File.ReadAllLines($@"{rootdirect}\cars.txt");
            List<string> Tesla = new List<string>();
            List<string> Toyota = new List<string>();
            List<string> bmw = new List<string>();

            foreach (string element in datafromfile)
            {
                if (element.Contains("Toyota"))
                {
                    Toyota.Add(element);
                }
                if (element.Contains("BMW"))
                {
                    bmw.Add(element);
                }
                else if (element.Contains("Tesla"))
                {
                    Tesla.Add(element);
                }

                File.WriteAllLines($@"{rootdirect}\Toyota.txt", Toyota);
                File.WriteAllLines($@"{rootdirect}\Bmw.txt", bmw);
                File.WriteAllLines($@"{rootdirect}\Tesla.txt", Tesla);
            }





        }
    }

}