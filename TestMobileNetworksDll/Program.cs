using BotswanaMobileNetworkOperators;
using System;

namespace TestMobileNetworksDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            var number = Console.ReadLine();
            var output = BotswanaNetworkProvider.GetMobileNetworkProvider(number);
            Console.WriteLine($"{output.Phone} - {output.NetworkProvider}");
        }
    }
}
