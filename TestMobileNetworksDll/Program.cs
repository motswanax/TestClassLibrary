using BotswanaMobileNetworkOperators;
using System;

namespace TestMobileNetworksDll
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberFromUser;
            do
            {
                Console.WriteLine("Enter your mobile number or type x to exit: ");
                numberFromUser = Console.ReadLine();
                if (numberFromUser == "x")
                    Environment.Exit(0);
                var response = BotswanaNetworkProvider.GetMobileNetworkProvider(numberFromUser);


                if (response.Item2 == 200)
                {
                    Console.WriteLine($"Phone: {response.Item1.Phone}\nOperator: {response.Item1.NetworkProvider}");
                }
                else
                {
                    Console.WriteLine($"{numberFromUser} - {response.Item3}");
                }
            } while (numberFromUser != "x" || numberFromUser != "X");
        }
    }
}
