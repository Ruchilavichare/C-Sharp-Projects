using System;

namespace BMICalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BMI Calculator App!");

            Console.Write("Enter your weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height in centimeters: ");
            double heightCM = Convert.ToDouble(Console.ReadLine());

            // Convert height from centimeters to meters
            double heightM = heightCM / 100;

            double bmi = CalculateBMI(weight, heightM);

            Console.WriteLine($"Your BMI is: {bmi}");
            Console.WriteLine($"BMI Category: {GetBMICategory(bmi)}");

            DisplayCategorySuggestions(bmi);
            Console.ReadLine();
        }

        static double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }

        static void DisplayCategorySuggestions(double bmi)
        {
            switch (GetBMICategory(bmi))
            {
                case "Underweight":
                    Console.WriteLine("Suggestions for Underweight:");
                    Console.WriteLine("- Consider consulting a healthcare professional or dietitian for advice on gaining weight in a healthy way.");
                    Console.WriteLine("- Focus on consuming nutrient-dense foods and increasing calorie intake.");
                    Console.WriteLine("- Incorporate strength training exercises to build muscle mass.");
                    break;
                case "Normal weight":
                    Console.WriteLine("Suggestions for Normal weight:");
                    Console.WriteLine("- Maintain a balanced diet that includes a variety of fruits, vegetables, lean proteins, and whole grains.");
                    Console.WriteLine("- Stay physically active with regular exercise such as walking, jogging, cycling, or swimming.");
                    Console.WriteLine("- Aim to maintain your current weight by balancing calorie intake with physical activity.");
                    break;
                case "Overweight":
                    Console.WriteLine("Suggestions for Overweight:");
                    Console.WriteLine("- Set realistic weight loss goals and make gradual changes to your diet and lifestyle.");
                    Console.WriteLine("- Focus on portion control and reducing intake of high-calorie, processed foods.");
                    Console.WriteLine("- Increase physical activity with a combination of aerobic exercises (e.g., brisk walking, running) and strength training.");
                    break;
                case "Obese":
                    Console.WriteLine("Suggestions for Obese:");
                    Console.WriteLine("- Seek guidance from a healthcare provider or registered dietitian for personalized weight loss strategies.");
                    Console.WriteLine("- Emphasize portion control and prioritize whole, nutrient-rich foods over processed or high-calorie options.");
                    Console.WriteLine("- Engage in regular physical activity tailored to your fitness level and preferences, aiming for at least 150 minutes of moderate-intensity exercise per week.");
                    break;
                default:
                    break;
            }
        }
    }
}
