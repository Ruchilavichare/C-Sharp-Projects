using System;
using System.Collections.Generic;

namespace CurrencyConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Currency Converter App!");
            Console.WriteLine("Available currencies: USD, EUR, GBP, JPY, AUD, INR, BHD, KWD, CAD, CHF, PKR");

            string[] currencies = { "USD", "EUR", "GBP", "JPY", "AUD", "INR", "BHD", "KWD", "CAD", "CHF", "PKR" };

            Console.WriteLine("Choose the source currency:");
            for (int i = 0; i < currencies.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {currencies[i]}");
            }
            Console.Write("Enter your choice (1-11): ");
            int sourceChoice = Convert.ToInt32(Console.ReadLine());
            string sourceCurrency = currencies[sourceChoice - 1];

            Console.Write($"Enter the amount in {sourceCurrency}: ");
            double sourceAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose the target currency:");
            for (int i = 0; i < currencies.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {currencies[i]}");
            }
            Console.Write("Enter your choice (1-11): ");
            int targetChoice = Convert.ToInt32(Console.ReadLine());
            string targetCurrency = currencies[targetChoice - 1];

            double convertedAmount = ConvertCurrency(sourceAmount, sourceCurrency, targetCurrency);

            Console.WriteLine($"Amount in {targetCurrency}: {convertedAmount}");
            Console.ReadLine();
        }

        static double ConvertCurrency(double amount, string sourceCurrency, string targetCurrency)
        {
            Dictionary<string, double> exchangeRates = new Dictionary<string, double>()
            {
                {"USD", 1.0},
                {"EUR", 0.92},
                {"GBP", 0.79},
                {"JPY", 150.10},
                {"AUD", 1.53},
                {"INR", 82.85},
                {"BHD", 0.38},
                {"KWD", 0.31},
                {"CAD", 1.36},
                {"CHF", 0.88},
                {"PKR", 278.33}
            };

            double sourceRate = exchangeRates[sourceCurrency];
            double targetRate = exchangeRates[targetCurrency];

            return amount / sourceRate * targetRate;
        }
    }
}
