using System;
using System.Threading;

namespace SimpleStopwatchApp
{
    class Program
    {
        static bool isRunning = false;
        static bool isPaused = false;
        static DateTime startTime;
        static TimeSpan elapsedTime;

        static void Main(string[] args)
        {
            Console.WriteLine("Simple Stopwatch");

            while (true)
            {
                Console.WriteLine("Press ENTER to start or pause the stopwatch.");
                Console.WriteLine("Press Q to quit the program.");

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.Enter:
                        if (!isRunning)
                        {
                            StartStopwatch();
                        }
                        else
                        {
                            if (!isPaused)
                            {
                                PauseStopwatch();
                            }
                            else
                            {
                                ResumeStopwatch();
                            }
                        }
                        break;
                    case ConsoleKey.Q:
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        static void StartStopwatch()
        {
            isRunning = true;
            startTime = DateTime.Now;
            Console.WriteLine("Stopwatch started. Press ENTER to pause.");
            while (isRunning)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    PauseStopwatch();
                }
                else
                {
                    elapsedTime = DateTime.Now - startTime;
                    DisplayElapsedTime();
                    Thread.Sleep(10); // Sleep for 10 milliseconds
                }
            }
        }

        static void PauseStopwatch()
        {
            isPaused = true;
            Console.WriteLine("Stopwatch paused. Press ENTER to resume.");
            while (isPaused)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    ResumeStopwatch();
                }
            }
        }

        static void ResumeStopwatch()
        {
            isPaused = false;
            Console.WriteLine("Stopwatch resumed. Press ENTER to pause.");
            startTime = DateTime.Now - elapsedTime; // Adjust start time to account for paused time
        }

        static void DisplayElapsedTime()
        {
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"Elapsed Time: {elapsedTime:mm\\:ss\\.fff}");
        }
    }
}
