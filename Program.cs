using System;
using System.Threading;
using leftTransposingByOne.Models;
using leftTransposingByOne.Helpers;

namespace leftTransposingByOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!" + "\n");
            Thread.Sleep(750);
            Console.WriteLine("Please enter your coded text: ");

            string codedText = Console.ReadLine();

            TransposedTextConverter TextConverter = new TransposedTextConverter(codedText);

            Console.WriteLine("\n" + "Thanks! Decoding message: ");
            Thread.Sleep(750);
            Console.WriteLine(TextConverter.DecodedText);

            Thread.Sleep(2500);
            Console.Write("\nThanks! See you later! Press any key to exit: ");
            Console.ReadKey();

            
        }
    }
}
