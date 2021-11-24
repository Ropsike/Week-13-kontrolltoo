using System;
using System.IO;

namespace Ülesanne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\test";
            string userToyota = "Toyota";
            string userBmw = "Bmw";
            string userTesla = "Tesla";


            string fullToyotaPath = $@"{rootDirectory}\{userToyota}.txt";
            string fullBmwPath = $@"{rootDirectory}\{userBmw}.txt";
            string fullTeslaPath = $@"{rootDirectory}\{userTesla}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileToyotaExists = File.Exists(fullToyotaPath);
            bool fileBmwExists = File.Exists(fullBmwPath);
            bool fileTeslaExists = File.Exists(fullTeslaPath);

            if (directoryExists && fileToyotaExists && fileBmwExists && fileTeslaExists)
            {
                Console.WriteLine($"{userToyota} and {userBmw} and {userTesla} already exists in {rootDirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(fullToyotaPath);
                File.Create(fullBmwPath);
                File.Create(fullTeslaPath);
                Console.WriteLine($"{userToyota} and {userBmw} and {userTesla} already exists in {rootDirectory}");

            }
            else
            {
                File.Create(fullToyotaPath);
                File.Create(fullBmwPath);
                File.Create(fullTeslaPath);
                
                Console.WriteLine($"{userToyota} and {userBmw} and {userTesla} has been created in {rootDirectory}");
            }
        }
    }
}