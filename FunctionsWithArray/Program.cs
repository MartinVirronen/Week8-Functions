using System;

namespace FunctionsWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            PickrandomColor(colors);
        }
        private static void PickrandomColor(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            Console.WriteLine(someArray[randomIndex]);
        }
    }
}
