using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Quiz App!");
            Console.WriteLine("Answer the following questions:");

            // Questions, options, and answers
            string[] questions = {
                "Which team won the first IPL season?",
                "Who is the highest run-scorer in IPL history?",
                "Who is the only player to take a hat-trick in IPL finals?",
                "Who is the first player to score 5000 runs in IPL history?",
                "Who is the first player to score a century in IPL?"
            };
            string[][] options = {
                new string[] { "A) Rajasthan Royals", "B) Mumbai Indians", "C) Deccan Chargers", "D) Chennai Super Kings" },
                new string[] { "A) Suresh Raina", "B) Virat Kohli", "C) Chris Gayle", "D) Rohit Sharma" },
                new string[] { "A) Amit Mishra", "B) Rohit Sharma", "C) Shane Watson", "D) Pravin Tambe" },
                new string[] { "A) Suresh Raina", "B) Virat Kohli", "C) David Warner", "D) Rohit Sharma" },
                new string[] { "A) Chris Gayle", "B) Manish Pandey", "C) Shane Watson", "D) Brendon McCullum" }
            };
            string[] answers = { "A", "B", "C", "B", "D" };

            // Display questions and get user answers
            int score = 0;
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {questions[i]}");
                foreach (string option in options[i])
                {
                    Console.WriteLine(option);
                }
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine().ToUpper();

                if (userAnswer == answers[i])
                {
                    score++;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is: {answers[i]}\n");
                }
            }

            // Display result
            Console.WriteLine("\nQuiz Results:");
            Console.WriteLine($"Correct Answers: {score}/{questions.Length}");
            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }
    }
}
